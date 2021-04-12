using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    * 文件名称  :StudentApi
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-11 11:06:52
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class StudentApi
    {
        private const string Route = "Student/";

        public async Task<List<Student>> GetStudents(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetStudents?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Student>>(((JArray) data.ResultData).ToString());
        }
        public async Task<int> GetStudentTotal()
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetStudentsTotal", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<int>(data.ResultData.ToString());
        }

        public async Task<Student> GetStudent(Guid id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetStudent/{id}",
                new Dictionary<string, object>());

            var res = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<Student>(((JObject) res.ResultData).ToString());
        }

        public async Task<List<Student>> GetStudents(Dictionary<string, object> dic)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetStudentsByParameter?",
                 dic);
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Student>>(((JArray)data.ResultData).ToString());
        }

        public async Task<JsonMessageResult> CreateStudent(Student model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}CreateStudent",
                CommonClass.ClassToDictionary(model));


            return string.IsNullOrEmpty(response)
                ? MsgProvider.Success("新增成功！")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        public async Task<JsonMessageResult> UpdateStudent(Student model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}UpdateStudent/{model.Id}?fields=Age,Sex,StudentName,DepartmentId,BirthDay,StudentNo,Class,Contact,Email",
                CommonClass.ClassToDictionary(model));
            return string.IsNullOrEmpty(response)
                ? MsgProvider.Success("修改成功！")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }
    }
}
