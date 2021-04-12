using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.MODEL.CommonModel;
using LibraryManagementSystemModel;
using LibraryManagementSystemModel.ChartDto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryManagementSystemApiRequest
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemApiRequest
    * 文件名称  :ChartApi
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-28 10:16:25
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public class ChartApi
    {
        private const string Route = "Chart/";

        public async Task<List<BookChartDto>> GetBookChartByCategory()
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}BooksSummaryByCategory", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<BookChartDto>>(((JArray)data.ResultData).ToString());
        }
        public async Task<List<BorrowChartDto>> GetBorrowByDayChart()
        {
            var response = await ApiRequestHandler.RequestHandler(HttpRequestMethods.Get,
                $"{Route}BorrowSummaryByDayChart", new Dictionary<string, object>());
            var data = JsonConvert.DeserializeObject<JsonMessageResult>(response);
            return JsonConvert.DeserializeObject<List<BorrowChartDto>>(((JArray)data.ResultData).ToString());
        }
    }
}
