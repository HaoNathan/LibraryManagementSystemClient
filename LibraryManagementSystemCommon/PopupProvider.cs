using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using LibraryManagementSystemModel.CacheData;

namespace LibraryManagementSystemCommon
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemCommon
    * 文件名称  :PopupProvider.cs
    * 机器名称  :ADMINISTRATOR-5
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-02-22 20:47:46 
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :提供消息提示框
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public static class PopupProvider
    {
        static PopupProvider()
        {
            var panel = GlobalCache.Form;
            FlyPanel = GlobalCache.FlyPanel;
            FlyPanel.OwnerControl = panel;
        }

        private static readonly FlyoutPanel FlyPanel;

        public static void Success(string message)
        {
            foreach (Control control in FlyPanel.Controls)
            {
                switch (control)
                {
                    case PictureEdit picture:
                        picture.SvgImage = SvgImage.FromFile(Application.StartupPath + "/Resource/Success.svg");
                        break;
                    case LabelControl label:
                        label.Text = message;
                        break;
                }
            }

            FlyPanel.ShowPopup(false);
        }

        /// <summary>
        /// 弹窗--Error[带异常记录]
        /// </summary>
        /// <param name="message">提示信息</param>
        /// <param name="ex">异常信息</param>
        public static void Error(string message,Exception ex)
        {

            foreach (Control control in FlyPanel.Controls)
            {
                switch (control)
                {
                    case LabelControl label:
                        label.Text = message;
                        break;
                    case PictureEdit picture:
                        picture.SvgImage = SvgImage.FromFile(Application.StartupPath + $"/Resource/Error.svg");
                        break;
                }
            }

            FlyPanel.ShowPopup(false);
            LogHelper.Error(ex.ToString());
        }

        public static void Warning(string message)
        {

            foreach (Control control in FlyPanel.Controls)
            {
                switch (control)
                {
                    case LabelControl label:
                        label.Text = message;
                        break;
                    case PictureEdit picture:
                        picture.SvgImage = SvgImage.FromFile(Application.StartupPath+$"/Resource/Warning.svg");
                        break;
                }
            }

            FlyPanel.ShowPopup(false);
        }
    }
}
