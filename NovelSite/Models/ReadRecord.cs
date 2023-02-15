using SqlSugar;

namespace NovelSite.Models
{
    public class ReadRecord
    {
        /// <summary>
        /// 阅读记录ID，自增主键，唯一标识一条阅读记录
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int RecordId { get; set; }

        /// <summary>
        /// 用户ID，标识该条阅读记录属于哪个用户
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int UserId { get; set; }

        /// <summary>
        /// 小说ID，标识该条阅读记录属于哪本小说
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int NovelId { get; set; }

        /// <summary>
        /// 章节ID，标识该条阅读记录属于哪个章节
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int ChapterId { get; set; }

        /// <summary>
        /// 阅读日期，该条阅读记录的日期
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public DateTime ReadDate { get; set; }

        /// <summary>
        /// 阅读进度，记录用户该条阅读记录的阅读进度
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int ReadProgress { get; set; }
    }

}
