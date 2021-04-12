using System;
using System.Drawing;
using System.Net.Mime;

namespace LibraryManagementSystemModel
{
    /// <summary>
    /// 书籍实体类
    /// </summary>
    public class Book
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
        ///书籍详细信息
        /// </summary>
        public Guid BookInfoId { get; set; }

        ///<summary>
        ///书籍状态
        /// </summary>
        public int BookState { get; set; }

        ///<summary>
        ///书籍状态名称
        /// </summary>
        public string BookStateName { get; set; }

        ///<summary>
        ///书籍类型
        /// </summary>
        public Guid BookCategoryId { get; set; }

        ///<summary>
        ///类别名称
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
        public Decimal Price { get; set; }

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
        ///封面图片
        /// </summary>
        public Image Photo { get; set; }

        ///<summary>
        ///作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// ISBN号
        /// </summary>
        public string ISBN { get; set; }

    }
}