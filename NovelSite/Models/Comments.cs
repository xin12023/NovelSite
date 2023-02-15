using SqlSugar;
using System.Security.Principal;

namespace NovelSite.Models
{
    public class Comments
    {
        /// <summary>
        /// 评论ID，自增主键，唯一标识一条评论
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int CommentId { get; set; }

        /// <summary>
        /// 用户ID，标识该评论的用户
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int UserId { get; set; }

        /// <summary>
        /// 小说ID，标识该评论所属的小说
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int NovelId { get; set; }

        /// <summary>
        /// 章节ID，标识该评论所属的章节
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int ChapterId { get; set; }

        /// <summary>
        /// 评论内容，记录该评论的文本内容
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? CommentContent { get; set; }

        /// <summary>
        /// 评论日期，记录该评论的发表日期
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime CommentDate { get; set; }

        /// <summary>
        /// 点赞数，记录该评论获得的点赞数量
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public int LikeCount { get; set; }
    }
}
