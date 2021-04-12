﻿using System;

namespace LibraryManagementSystemModel
{
    /*===============================================
    * CLR 版本  :4.0.30319.42000
    * 命名空间  :LibraryManagementSystemModel
    * 文件名称  :BookInfo.cs
    * 机器名称  :ADMINISTRATOR-5
    * ----------------------------------------
    * 创 建 者  :向豪
    * 创建日期  :2021-01-17 17:05:12 
    * 邮    箱  :2224613103@qq.com
    * 功能描述  :
    * 使用说明  :书籍信息实体类
    * ----------------------------------------
    * 修改者    :
    * 修改日期  :
    * 修改内容  :
    =================================================*/
    /// <summary>
    /// 书籍信息实体类
    /// </summary>
    public class BookInfo
    {
        /// <summary>
        /// ID  
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        ///是否移除
        /// </summary>

        public bool IsRemove { get; set; }

        ///<summary>
        ///书籍类型
        /// </summary>
        public Guid BookCategoryId { get; set; }

        ///<summary>
        ///书籍类型名称
        /// </summary>
        public string CategoryName { get; set; }

        ///<summary>
        ///出版社
        /// </summary>
        public Guid PublishingId { get; set; }

        ///<summary>
        ///出版社名称
        /// </summary>
        public string PublishingName { get; set; }

        ///<summary>
        ///价格
        /// </summary>
        public decimal Price { get; set; }

        ///<summary>
        ///发布时间
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        ///<summary>
        ///书籍名
        /// </summary>
        public string BookName { get; set; }

        ///<summary>
        ///封面
        /// </summary>
        public string BookPhoto { get; set; }

        ///<summary>
        ///作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// ISBN号
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// 书籍数量
        /// </summary>
        public int BookNum { get; set; }

    }
}
