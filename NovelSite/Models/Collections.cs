using SqlSugar;
using System.Security.Principal;

namespace NovelSite.Models
{
    public class Collections
    {
        /// <summary>
        /// 收藏ID，自增主键，唯一标识一个收藏记录
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int CollectionId { get; set; }

        /// <summary>
        /// 用户ID，收藏者的用户ID
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int UserId { get; set; }

        /// <summary>
        /// 小说ID，被收藏的小说ID
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int NovelId { get; set; }

        /// <summary>
        /// 收藏日期，收藏时间
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime CollectionDate { get; set; }

    }
}
