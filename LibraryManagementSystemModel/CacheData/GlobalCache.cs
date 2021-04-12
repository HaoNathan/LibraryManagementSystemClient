using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;

namespace LibraryManagementSystemModel.CacheData
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemClient.CacheData
    * 文件名称  :AdminCache.cs
    * 机器名称  :ADMINISTRATOR-5
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-01-23 22:16:08 
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :用于存放全局变量
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    public static class GlobalCache
    {
        /// <summary>
        /// 管理员信息
        /// </summary>
        public static Admin Admin = new Admin();

        /// <summary>
        /// token前缀
        /// </summary>
        public static string Token = "Bearer ";

        /// <summary>
        /// 用于访问弹窗组件
        /// </summary>
        public static FlyoutPanel FlyPanel;
        
        /// <summary>
        /// 用于放置弹窗组件的容器
        /// </summary>
        public static XtraForm Form;

        public static Type Type;
    }
}
