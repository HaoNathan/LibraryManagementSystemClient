using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraLayout;

namespace LibraryManagementSystemCommon
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemCommon
    * 文件名称  :CommonClass.cs
    * 机器名称  :ADMINISTRATOR-5
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-02-18 11:29:26 
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public static class CommonClass
    {
        /// <summary>
        /// 类转换字典
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Dictionary<string, object> ClassToDictionary<T>(T obj)
        {
            var properties = typeof(T).GetProperties();
            return properties.ToDictionary(property => property.Name, property => property.GetValue(obj));
        }

        /// <summary>
        /// 清空TextEdit数据
        /// </summary>
        /// <param name="group"></param>
        public static void ClearInfo(LayoutControlGroup group)
        {
            foreach (LayoutControlItem item in group.Items)
            {
                switch (item.Control)
                {
                    case TextEdit textEdit:
                        textEdit.Text = string.Empty;
                        break;
                    case PictureEdit pic:
                        pic.Image = null;
                        break;
                }
            }
        }

        /// <summary>
        /// 设置DateEdit控件属性
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="day"></param>
        public static void SetDateEditProperties(DateEdit begin, DateEdit end, int day)
        {
            begin.DateTime = Convert.ToDateTime(DateTime.Now.AddDays(-day).ToString("yyyy-MM-dd HH:mm:ss"));
            end.DateTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            end.Properties.MaskSettings.Set("mask", "G");
            end.Properties.DisplayFormat.FormatString = "G";
            end.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            end.Properties.EditFormat.FormatString = "G";
            end.Properties.EditFormat.FormatType = FormatType.DateTime;
            begin.Properties.MaskSettings.Set("mask", "G");
            begin.Properties.DisplayFormat.FormatString = "G";
            begin.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            begin.Properties.EditFormat.FormatString = "G";
            begin.Properties.EditFormat.FormatType = FormatType.DateTime;
        }
    }
}
