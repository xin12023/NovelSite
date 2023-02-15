using SqlSugar;
using System.Security.Principal;

namespace NovelSite.Models
{
    public class Novels
    {
        /// <summary>
        /// 小说ID，自增主键，唯一标识一本小说
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int NovelId { get; set; }

        /// <summary>
        /// 小说名称
        /// </summary>
        [SugarColumn(Length = 50, IsNullable = false)]
        public string? NovelName { get; set; }

        /// <summary>
        /// 作者名称
        /// </summary>
        [SugarColumn(Length = 20, IsNullable = true)]
        public string? AuthorName { get; set; }

        /// <summary>
        /// 分类ID，与分类表关联
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int CategoryId { get; set; }

        /// <summary>
        /// 封面图片
        /// </summary>
        [SugarColumn(Length = 200, IsNullable = true)]
        public string? CoverImage { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? Introduction { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// 状态，表示小说是连载还是已完结
        /// </summary>
        [SugarColumn(Length = 10, IsNullable = false)]
        public string? Status { get; set; }

        /// <summary>
        /// 推荐数量，记录用户对该小说的推荐次数
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int RecommendationCount { get; set; }
    }
}
