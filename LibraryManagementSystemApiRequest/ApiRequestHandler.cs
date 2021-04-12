using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;
using LibraryManagementSystemModel.CacheData;
using Newtonsoft.Json;

namespace LibraryManagementSystemApiRequest
{
    public static class ApiRequestHandler
    {
        #region 字段

        /// <summary>
        /// API请求
        /// </summary>
        private static readonly HttpClient Client;

        /// <summary>
        /// 资源格式
        /// </summary>
        private const string MediaType = "application/json";

        /// <summary>
        /// 请求Api接口地址
        /// </summary>
        private static readonly string ApiUrl = $"{ConfigurationManager.AppSettings["ApiUrl"]}";

        /// <summary>
        /// 返回信息
        /// </summary>
        private static readonly JsonMessageResult MsgResult = new JsonMessageResult("Success", 1, null);

        #endregion

        #region 静态构造函数

        static ApiRequestHandler()
        {
            Client = new HttpClient { BaseAddress = new Uri(ApiUrl) };
        }

        #endregion

        public static async Task<string> RequestHandler(HttpRequestMethods method, string url,
            Dictionary<string, object> dic, string jsonData = "")
        {
            try
            {
                //传入Authorization Token
                Client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(GlobalCache.Token);

                HttpResponseMessage response;
                switch (method)
                {
                    //GET请求
                    case HttpRequestMethods.Get:

                        url = dic.Keys.Aggregate(url, (current, item) => current + $"{item}={dic[item]}&");
                        return await Client.GetStringAsync($"{ApiUrl + url}");

                    //POST
                    case HttpRequestMethods.Post:
                        var bodyData = JsonConvert.SerializeObject(dic);
                        if (!string.IsNullOrEmpty(jsonData))
                        {
                            bodyData = jsonData;
                        }

                        response = await Client.PostAsync($"{ApiUrl + url}",
                            new StringContent(bodyData, Encoding.UTF8, MediaType));
                        if (response.StatusCode != HttpStatusCode.Created)
                            return await response.Content.ReadAsStringAsync();
                        var strData = await response.Content.ReadAsStringAsync();
                        MsgResult.ResultMessage = "创建成功！";
                        MsgResult.ResultData = strData;
                        return JsonConvert.SerializeObject(MsgResult);

                    //PUT
                    case HttpRequestMethods.Put:

                        response = await Client.PutAsync($"{ApiUrl + url}",
                            new StringContent(JsonConvert.SerializeObject(dic), Encoding.UTF8, MediaType));

                        if (response.StatusCode != HttpStatusCode.NoContent)
                            return await response.Content.ReadAsStringAsync();

                        return JsonConvert.SerializeObject(new JsonMessageResult("修改成功", 1, 0));
                    //DELETE
                    case HttpRequestMethods.Delete:

                        response = await Client.DeleteAsync($"{ApiUrl + url}");
                        var result = await response.Content.ReadAsStringAsync();
                        return string.IsNullOrEmpty(result)
                            ? JsonConvert.SerializeObject(new JsonMessageResult("删除成功", 1, 0))
                            : result;

                    case HttpRequestMethods.Patch:
                        break;
                    default:
                        return "未找到此请求方式！";
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                    return JsonConvert.SerializeObject(new JsonMessageResult("未找到接口资源或未授权！", 0, null));
                if (e.Status != WebExceptionStatus.ProtocolError)
                    return JsonConvert.SerializeObject(new JsonMessageResult("请求异常！", 0, null));

                var reader = new StreamReader(
                    e.Response.GetResponseStream() ?? throw new InvalidOperationException(),
                    Encoding.UTF8);
                using (reader) return await reader.ReadToEndAsync();
            }
            catch (HttpRequestException e)
            {
                LogHelper.Error(e.ToString());
                return MsgProvider.FailMsg($"接口请求异常！{e.Message}");
            }
            catch (Exception e)
            {
                LogHelper.Error(e.ToString());
                return MsgProvider.FailMsg($"发生异常：{e.Message}");
            }

            return "请求异常！";
        }

        #region 利用委托进行重构

        public static async Task<string> RequestHandler(Func<Task<string>> func)
        {
            return await func.Invoke();
        }

        public static async Task<string> Post()
        {
            var str = await RequestHandler(async () =>
            {
                var response = await Client.PostAsync("", new StringContent(""));
                return await response.Content.ReadAsStringAsync();
            });
            return str;
        }

        #endregion

    }
}