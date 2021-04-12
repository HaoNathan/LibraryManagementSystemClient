using System;

namespace LibraryManagementSystemModel
{
    /// <summary>
    /// 管理员权限实体类
    /// </summary>
    public class Authority
    {
        ///<summary>
        ///权限
        /// </summary>
        public string Authorities { get; set; }

        /// <summary>
        /// 权限编号
        /// </summary>
        public string AuthorityNum { get; set; }

        /// <summary>
        /// 权限父节点
        /// </summary>
        public string AuthorityParent { get; set; }

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
    }
}