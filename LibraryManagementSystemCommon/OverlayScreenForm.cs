using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using LibraryManagementSystemModel.CacheData;

namespace LibraryManagementSystemCommon
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemCommon
    * 文件名称  :OverlayScreenForm
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-03-09 21:49:13
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public static class OverlayScreenForm
    {
        public static IOverlaySplashScreenHandle ShowProgressPanel(XtraForm form)
        {
            return SplashScreenManager.ShowOverlayForm(form,
                new OverlayWindowOptions {ImageSize = new Size(20, 20)});
        }

        public static void CloseProgressPanel(IOverlaySplashScreenHandle handle)
        {
            if (handle != null)
                SplashScreenManager.CloseOverlayForm(handle);
        }
    }
}
