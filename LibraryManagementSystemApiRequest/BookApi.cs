using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryManagementSystemApiRequest
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemApiRequest
    * 文件名称  :BookApi
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-06 19:36:21
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class BookApi
    {
        #region 字段

        private const string Route = "Book/";

        #endregion

        public async Task<List<Book>> GetBooks(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBooks?includeRemove={includeRemove}", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Book>>(((JArray) data.ResultData).ToString());
        }

        public async Task<Book> GetBook(Guid id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBook/{id}", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<Book>(((JObject) data.ResultData).ToString());
        }

        public async Task<int> GetBookTotal()
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBooksTotal", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<int>(data.ResultData.ToString());
        }

        public async Task<List<Book>> GetBooks(Dictionary<string, object> dicPara)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBooksByParameter?", dicPara);
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Book>>(((JArray) data.ResultData).ToString());
        }

        public async Task<JsonMessageResult> CreateBook(Guid infoId)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post, $"{Route}CreateBook",
                new Dictionary<string, object>
                {
                    {"BookInfoId", infoId},
                    {"BookState", 0}
                });
            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }
    }
}
