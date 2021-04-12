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
    * 文件名称  :EmployeeApi
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-11 11:10:45
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class EmployeeApi
    {
        private const string Route = "Employee/";

        public async Task<List<Employee>> GetEmployees(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetEmployees?includeRemove={includeRemove}", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Employee>>(((JArray)data.ResultData).ToString());
        }
        public async Task<int> GetEmployeeTotal()
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetEmployeesTotal", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<int>(data.ResultData.ToString());
        }

        public async Task<Employee> GetEmployee(Guid id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetEmployee/{id}",
                new Dictionary<string, object>());

            var res = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<Employee>(((JObject)res.ResultData).ToString());
        }

        public async Task<JsonMessageResult> CreateEmployee(Employee model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}CreateEmployee",
                CommonClass.ClassToDictionary(model));

            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        public async Task<JsonMessageResult> UpdateEmployee(Employee model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}UpdateEmployee/{model.Id}?fields=Age,Sex,EmployeeName,DepartmentId,BirthDay,Contact",
                CommonClass.ClassToDictionary(model));
            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }
        public async Task<List<Employee>> GetEmployees(Dictionary<string, object> dic)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetEmployeesByParameter?",
                dic);
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Employee>>(((JArray)data.ResultData).ToString());
        }
    }
}
