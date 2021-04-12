using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Baidu.Aip.Face;
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemCommon;
using LibraryManagementSystemModel;
using LibraryManagementSystemModel.CacheData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryManagementSystemApiRequest
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemApiRequest.AdminApiRequest
    * 文件名称  :AdminApi.cs
    * 机器名称  :ADMINISTRATOR-5
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-01-23 15:29:08 
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :管理员数据请求接口
    * 使用说明  :用于获取管理员相关数据
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class AdminApi
    {
        #region 字段

        private const string Route = "Admin/";

        #endregion

        #region 人脸识别登录

        /// <summary>
        /// 人脸授权登陆
        /// </summary>
        /// <param name="image">人脸图像</param>
        /// <returns></returns>
        public async Task<bool> Login(Bitmap image)
        {
            var res = (JObject) JsonConvert.DeserializeObject(FaceRecognition(image).ToString());
            if (res == null) return false;
            var bdRes = (JObject) JsonConvert.DeserializeObject(res["result"]?.ToString() ?? string.Empty);
            var str = bdRes?["user_list"]?.ToString().Replace("[", "");
            if (str == null) return false;
            var data = str.Replace("]", "").Trim();
            var aiRes = JsonConvert.DeserializeObject<AiResult>(data);
            var resultLogin = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}Login",
                new Dictionary<string, object>
                {
                    {"adminName", aiRes.User_Id},
                    {"adminPassword", "FaceRecognition"}
                });
            var apiRes = JsonConvert.DeserializeObject<JsonMessageResult>(resultLogin);

            if (apiRes.ResultCode == 1)
            {
                GlobalCache.Admin.AdminName = aiRes.User_Id;
                GlobalCache.Admin.AdminPassword = "FaceRecognition";
                GlobalCache.Token += apiRes.ResultMessage;
            }

            return apiRes.ResultCode == 1;
        }

        /// <summary>
        /// 百度人脸识别认证查询
        /// </summary>
        /// <param name="image"></param>
        /// <returns>接口响应数据</returns>
        private JObject FaceRecognition(Bitmap image)
        {
            var API_KEY = "uQB5WmQUvsSYNyxEiQCOgXNS";
            var SECRET_KEY = "Dn4jKjqqNRfWOSZsA2MONAWrt5Aaxzgy";
            var client = new Face(API_KEY, SECRET_KEY) {Timeout = 60000};
            // 修改超时时间
            var imageType = "BASE64";
            // 如果有可选参数
            var options = new Dictionary<string, object>
            {
                {"max_face_num", 1},
                {"match_threshold", 70},
                {"quality_control", "NORMAL"},
                {"liveness_control", "LOW"},
                {"max_user_num", 1}
            };
            //带参数调用人脸检测
            return client.Search(image.ToBase64(), imageType, "1", options);
        }

        #endregion

        #region 账号登陆

        /// <summary>
        /// 账号验证登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> Login(Admin model)
        {
            var resultLogin = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}Login",
                new Dictionary<string, object>
                {
                    {"adminName", model.AdminName},
                    {"adminPassword", model.AdminPassword}
                });

            var apiRes = JsonConvert.DeserializeObject<JsonMessageResult>(resultLogin);

            if (apiRes.ResultCode != 1) return false;

            GlobalCache.Admin.AdminName = model.AdminName;
            GlobalCache.Admin.AdminPassword = model.AdminPassword;
            GlobalCache.Token += apiRes.ResultMessage;
            return true;
        }

        #endregion

        #region 获取单个信息

        public async Task<Admin> GetAdminInfo(Admin model)
        {
            var jsonData = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get, $"{Route}AdminInfo?",
                new Dictionary<string, object>
                {
                    {"Id", model.Id},
                    {"AdminName", model.AdminName},
                    {"AdminPassword", model.AdminPassword},
                });

            var result = JsonConvert.DeserializeObject<JsonMessageResult>(jsonData);
            if (result.ResultCode != 1)
            {
                return new Admin();
            }

            var jObject = (JObject) result.ResultData;
            return JsonConvert.DeserializeObject<Admin>(jObject.ToString());
        }

        #endregion

        #region 获取所有管理员信息

        public async Task<List<Admin>> GetAdmins(bool? includeRemove)
        {
            var jsonData = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetAdmins?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var result = JsonConvert.DeserializeObject<JsonMessageResult>(jsonData);

            if (result.ResultCode != 1)
            {
                return new List<Admin>();
            }

            var jObject = (JArray) result.ResultData;
            return JsonConvert.DeserializeObject<List<Admin>>(jObject.ToString());
        }

        public async Task<List<Admin>> GetAdminsByPara(Dictionary<string, object> dic)
        {
            var jsonData = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetAdminsByPara?",
                dic);

            var result = JsonConvert.DeserializeObject<JsonMessageResult>(jsonData);
            var jObject = (JArray) result.ResultData;
            return JsonConvert.DeserializeObject<List<Admin>>(jObject.ToString());
        }

        #endregion

        public async Task<bool> UpdateAdminPower(Guid id, string permissions)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}UpdateAdmin?fields=AdministratorRights",
                new Dictionary<string, object>
                {
                    {"Id", id},
                    {"AdministratorRights", permissions}
                });

            return JsonConvert.DeserializeObject<JsonMessageResult>(response).ResultCode == 1;
        }

        public async Task<JsonMessageResult> UpdateAdminPassword(Guid id, string password)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}UpdateAdmin?fields=AdminPassword",
                new Dictionary<string, object>
                {
                    {"Id", id},
                    {"AdminPassword", password}
                });

            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }
    }
}
