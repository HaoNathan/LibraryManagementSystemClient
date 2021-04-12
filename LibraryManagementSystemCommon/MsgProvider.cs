using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using LibraryManagementSystem.MODEL.CommonModel;
using Newtonsoft.Json;

namespace LibraryManagementSystemCommon
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemCommon
    * 文件名称  :MessageProvider.cs
    * 机器名称  :ADMINISTRATOR-5
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-02-21 10:39:21 
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :提供序列化和反序列化的返回消息
    * 使用说明  :返回提示信息
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    /// <summary>
    /// 提供序列化和反序列化的返回消息
    /// </summary>
    public static class MsgProvider
    {
        public static string SuccessMsg(string message, object data)
        {
            return JsonConvert.SerializeObject(new JsonMessageResult(message, 1, data));
        }

        public static string SuccessMsg(string message)
        {
            return JsonConvert.SerializeObject(new JsonMessageResult(message, 1, null));
        }

        public static string FailMsg(string message, object data)
        {
            return JsonConvert.SerializeObject(new JsonMessageResult(message, 0, data));
        }

        public static string FailMsg(string message)
        {
            return JsonConvert.SerializeObject(new JsonMessageResult(message, 0, null));
        }

        public static JsonMessageResult Success(string message, object data)
        {
            return new JsonMessageResult(message, 1, data);
        }

        public static JsonMessageResult Success(string message)
        {
            return new JsonMessageResult(message, 1, null);
        }

        public static JsonMessageResult Fail(string message, object data)
        {
            return new JsonMessageResult(message, 0, data);
        }

        public static JsonMessageResult Fail(string message)
        {
            return new JsonMessageResult(message, 0, null);
        }
    }
}
