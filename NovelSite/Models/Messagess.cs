using SqlSugar;
using System.Security.Principal;

namespace NovelSite.Models
{
    public class Messagess
    {
        /// <summary>
        /// 消息ID，自增主键，唯一标识一条站内信
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int MessageId { get; set; }

        /// <summary>
        /// 发送者ID，站内信发送者的用户ID
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int FromUserId { get; set; }

        /// <summary>
        /// 消息内容，站内信的具体内容
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? MessageContent { get; set; }

        /// <summary>
        /// 回复内容，站内信的回复内容
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? ReplyContent { get; set; }

        /// <summary>
        /// 发送时间，站内信的发送时间
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime SendTime { get; set; }

    }
}
