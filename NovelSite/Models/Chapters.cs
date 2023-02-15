using SqlSugar;
using System.Security.Principal;

namespace NovelSite.Models
{
    public class Chapters
    {
        /// <summary>
        /// 章节ID，自增主键，唯一标识一章节
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int ChapterId { get; set; }

        /// <summary>
        /// 小说ID，标识该章节属于哪本小说
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int NovelId { get; set; }

        /// <summary>
        /// 章节标题，该章节的标题
        /// </summary>
        [SugarColumn(Length = 100, IsNullable = false)]
        public string? ChapterTitle { get; set; }

        /// <summary>
        /// 章节内容，该章节的最终显示内容
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public string? ChapterContent { get; set; }

        /// <summary>
        /// 章节采集入库内容，该章节采集入库的原始内容
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? ChapterInitial { get; set; }

        /// <summary>
        /// 更新日期，该章节最近一次更新的日期
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime UpdateDate { get; set; }
    }
}
