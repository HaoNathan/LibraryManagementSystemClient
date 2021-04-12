using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.MODEL;
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryManagementSystemApiRequest
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemApiRequest
    * 文件名称  :SystemSettingApi.cs
    * 机器名称  :ADMINISTRATOR-5
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-02-15 15:12:49 
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class SystemSettingApi
    {
        private const string AdminRoute = "Admin/";
        private const string DepartmentRoute = "Department/";
        private const string CompanyDepartmentRoute = "CompanyDepartment/";

        public async Task<List<Authority>> GetAuthorities(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{AdminRoute}Authorities?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Authority>>(((JArray) data.ResultData).ToString());
        }

        public async Task<List<Departments>> GetDepartments(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{DepartmentRoute}GetDepartments?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Departments>>(((JArray)data.ResultData).ToString());
        }

        public async Task<List<CompanyDepartment>> GetCompanyDepartments(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{CompanyDepartmentRoute}GetCompanyDepartments?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<CompanyDepartment>>(((JArray)data.ResultData).ToString());
        }
    }
}
