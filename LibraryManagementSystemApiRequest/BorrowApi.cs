using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
    * 文件名称  :BorrowApi
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-21 21:02:20
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class BorrowApi
    {
        private const string Route = "Borrow/";

        public async Task<List<Borrow>> GetBorrows(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBorrows?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Borrow>>(((JArray)data.ResultData).ToString());
        }

        public async Task<Borrow> GetBorrow(Guid id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBorrow/{id}",
                new Dictionary<string, object>());

            var res = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<Borrow>(((JObject)res.ResultData).ToString());
        }

        public async Task<int> GetBorrowTotal()
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBorrowsTotal", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<int>(data.ResultData.ToString());
        }


        public async Task<List<Borrow>> GetBorrows(Dictionary<string, object> dic)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBorrowsByParameter?", dic);
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Borrow>>(((JArray)data.ResultData).ToString());
        }

        public async Task<JsonMessageResult> CreateBorrows(List<Borrow> borrows)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}CreateBorrow",
                new Dictionary<string, object>(), JsonConvert.SerializeObject(borrows, Formatting.Indented));

            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }
        public async Task<int> GetBorrowInfoTotal(string studentId)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetBorrowInfosTotal?studentId={studentId}",
                new Dictionary<string, object>());

            var res = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<int>(res.ResultData.ToString());
        }
        public async Task<JsonMessageResult> UpdateBookSate(Employee model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}UpdateBook/{model.Id}?fields=BookState",
                CommonClass.ClassToDictionary(model));
            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        public async Task<JsonMessageResult> ReturnBook(string id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}ReturnBook/{id}",
                new Dictionary<string, object>());
            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }
    }
}
