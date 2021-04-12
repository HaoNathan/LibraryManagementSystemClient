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
    public class BookInfoApi
    {
        private const string Route = "BookInfo/";

        #region Get请求

        public async Task<List<BookInfo>> GetBooksInfo(bool includeRemove = true)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}BooksInfo?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<BookInfo>>(((JArray)data.ResultData).ToString());
        }

        public async Task<List<BookInfo>> GetBooksInfo(Dictionary<string, object> dic)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}BooksInfoByParameter?",
                dic);

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<BookInfo>>(((JArray) data.ResultData).ToString());
        }

        public async Task<List<PublishingHouse>> GetPublishingHouses(bool includeRemove = true)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}PublishingHouses?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<PublishingHouse>>(((JArray)data.ResultData).ToString());
        }

        public async Task<List<BookCategory>> GetBookCategories(bool includeRemove = true)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}BookCategories?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<BookCategory>>(((JArray)data.ResultData).ToString());
        }

        #region 获取单个资源

        public async Task<BookInfo> GetBookInfo(Guid id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}BookInfo/{id}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<BookInfo>(((JObject)data.ResultData).ToString());
        }
        #endregion

        #endregion

        #region Post请求

        public async Task<JsonMessageResult> CreatePublishingHouse(PublishingHouse model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}CreatePublishingHouse",
                CommonClass.ClassToDictionary(model));

            return string.IsNullOrEmpty(response)
                ? MsgProvider.Success("新增成功！")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        public async Task<JsonMessageResult> CreateBookCategory(BookCategory model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}CreateBookCategory",
                CommonClass.ClassToDictionary(model));

            return string.IsNullOrEmpty(response)
                ? MsgProvider.Success("新增成功！")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        public async Task<JsonMessageResult> CreateBooksInfo(BookInfo model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}CreateBookInfo",
                CommonClass.ClassToDictionary(model));


            return string.IsNullOrEmpty(response)
                ? MsgProvider.Success("新增成功！")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        #endregion

        #region Put请求

        public async Task<JsonMessageResult> UpdateBookInfo(BookInfo model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}UpdateBookInfo/{model.Id}?fields=BookCategoryId,PublishingId,Price,ReleaseDate,BookName,BookPhoto,Author,ISBN",
                CommonClass.ClassToDictionary(model));

            return string.IsNullOrEmpty(response)
                ? MsgProvider.Success("修改成功！")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        #endregion

        #region Delete请求

        public async Task<JsonMessageResult> DeleteBooksInfo(Guid id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Delete,
                $"{Route}DeleteBookInfo",
                new Dictionary<string, object>());
            return string.IsNullOrEmpty(response)
                ? new JsonMessageResult("删除成功！", 1, "")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        #endregion
    }
}