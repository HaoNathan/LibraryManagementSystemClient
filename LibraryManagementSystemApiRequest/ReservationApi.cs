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
    * 文件名称  :ReservationApi
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-24 17:12:59
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class ReservationApi
    {
        private const string Route = "Reservation/";

        public async Task<List<Reservation>> GetReservations(bool includeRemove)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetReservations?includeRemove={includeRemove}",
                new Dictionary<string, object>());

            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Reservation>>(((JArray)data.ResultData).ToString());
        }

        public async Task<Reservation> GetReservation(Guid id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetReservation/{id}",
                new Dictionary<string, object>());

            var res = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<Reservation>(((JObject)res.ResultData).ToString());
        }

        public async Task<int> GetReservationTotal()
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetReservationsTotal", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<int>(data.ResultData.ToString());
        }

        public async Task<int> GetReservationInfoTotal(string studentId)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetReservationInfosTotal?studentId={studentId}",
                new Dictionary<string, object>());

            var res = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<int>(res.ResultData.ToString());
        }

        public async Task<List<Guid>> GetReservationBooks()
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetReservationBooks",
                new Dictionary<string, object>());

            var res = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Guid>>(res.ResultData.ToString());
        }

        public async Task<List<Reservation>> GetReservations(Dictionary<string, object> dic)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}GetReservationsByParameter?",
                 dic);
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<Reservation>>(((JArray)data.ResultData).ToString());
        }

        public async Task<JsonMessageResult> CreateReservations(List<Reservation> reservations)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Post,
                $"{Route}CreateReservation",
                new Dictionary<string, object>(), JsonConvert.SerializeObject(reservations, Formatting.Indented));

            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        public async Task<JsonMessageResult> UpdateReservation(Reservation model)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Put,
                $"{Route}UpdateReservation/{model.Id}?fields=Age,Sex,ReservationName,DepartmentId,BirthDay,ReservationNo,Class,Contact,Email",
                CommonClass.ClassToDictionary(model));
            return string.IsNullOrEmpty(response)
                ? MsgProvider.Success("修改成功！")
                : JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }

        public async Task<JsonMessageResult> DeleteReservation(string id)
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Delete,
                $"{Route}DeleteReservation/{id}",
                new Dictionary<string, object>());
            return JsonConvert.DeserializeObject<JsonMessageResult>(response);
        }
    }
}
