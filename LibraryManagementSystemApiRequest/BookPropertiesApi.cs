using System;
using System.Collections.Generic;
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
    * 文件名称  :BookPropertiesApi
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-07 19:36:00
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class BookPropertiesApi
    {
        #region 字段

        private const string BookRoute = "BookInfo/";

        #endregion

        #region 图书类别信息

        public async Task<JsonMessageResult> UpdateBookCategory(Guid id, bool isRemove)
        {
            var result = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{BookRoute}UpdateBookCategory/{id}?fields=IsRemove",
                new Dictionary<string, object>
                {
                    {"IsRemove", isRemove},
                    {"Fields" ,"IsRemove"}
                });
            return JsonConvert.DeserializeObject<JsonMessageResult>(result);
        }

        public async Task<JsonMessageResult> UpdateCategory(string id, string categoryName)
        {
            var result = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{BookRoute}UpdateBookCategory/{id}",
                new Dictionary<string, object>
                {
                    {"CategoryName", categoryName},
                    {"Fields","CategoryName" }
                });
            return JsonConvert.DeserializeObject<JsonMessageResult>(result);
        }
        #endregion


        #region 出版社信息

        public async Task<JsonMessageResult> UpdatePublishingHouse(Guid id, bool isRemove)
        {
            var result = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{BookRoute}UpdatePublishingHouse/{id}",
                new Dictionary<string, object>
                {
                    {"IsRemove", isRemove},
                    {"Fields", "IsRemove"}
                });
            return JsonConvert.DeserializeObject<JsonMessageResult>(result);
        }
        public async Task<JsonMessageResult> UpdatePublishingHouse(string id, string publishingName)
        {
            var result = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{BookRoute}UpdatePublishingHouse/{id}",
                new Dictionary<string, object>
                {
                    {"PublishingName", publishingName},
                    {"Fields", "PublishingName"}
                });
            return JsonConvert.DeserializeObject<JsonMessageResult>(result);
        }

        #endregion
    }
}
