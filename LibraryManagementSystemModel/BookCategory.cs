using System;

namespace LibraryManagementSystemModel
{
    /// <summary>
    /// 书籍类别实体类
    /// </summary>
    public class BookCategory
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
        ///类别名称
        /// </summary>
        public string CategoryName { get; set; }
    }
}