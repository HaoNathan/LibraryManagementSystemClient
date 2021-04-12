using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using DevExpress.XtraEditors;

namespace LibraryManagementSystemCommon
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemCommon
    * 文件名称  :ExtensionClass.cs
    * 机器名称  :ADMINISTRATOR-5
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-01-17 12:05:27 
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public static class ExtensionClass
    {
        public static string ToBase64(this Bitmap bmp)
        {
            try
            {
                var ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                var arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int) ms.Length);
                ms.Close();
                var baser64 = Convert.ToBase64String(arr);
                return baser64;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"ImgToBase64转换失败!" + ex.Message);
                return "";
            }
        }
    }
}
