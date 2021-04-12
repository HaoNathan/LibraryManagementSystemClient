using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.MODEL;
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryManagementSystemApiRequest
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemApiRequest
    * 文件名称  :FinePaymentApi
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-22 14:37:18
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class FinePaymentApi
    {
        private const string Route = "FinePayment/";

        public async Task<List<FinePayment>> GetFinePayments(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetFinePayments?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<FinePayment>>(((JArray)data.ResultData).ToString());
        }

        public async Task<FinePayment> GetFinePayment(Guid id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetFinePayment/{id}",
                new Dictionary<string, object>());

            var res = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<FinePayment>(((JObject)res.ResultData).ToString());
        }

        public async Task<List<FinePayment>> GetFinePayments(Dictionary<string, object> dic)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetFinePaymentsByParameter?",
                 dic);
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<FinePayment>>(((JArray)data.ResultData).ToString());
        }

        public async Task<JsonMessageResult> CreateFinePayment(FinePayment model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}CreateFinePayment",
                CommonClass.ClassToDictionary(model));

            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        public async Task<JsonMessageResult> UpdateFinePayment(FinePayment model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}UpdateFinePayment/{model.Id}?fields=Age,Sex,FinePaymentName,DepartmentId,BirthDay,FinePaymentNo,Class,Contact,Email",
                CommonClass.ClassToDictionary(model));
            return string.IsNullOrEmpty(response)
                ? MsgProvider.Success("修改成功！")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }
    }
}
