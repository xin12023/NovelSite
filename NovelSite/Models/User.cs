using SqlSugar;

namespace NovelSite.Models
{
    public class User
    {
        /// <summary>
        /// 用户ID，自增长，主键
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int UserId { get; set; }

        /// <summary>
        /// 用户名,最大长度20个字符,不可为空
        /// </summary>
        [SugarColumn(Length = 20, IsNullable = false)]
        public string? Username { get; set; }

        /// <summary>
        /// 用户密码,最大长度32个字符,不可为空
        /// </summary>
        [SugarColumn(Length = 32, IsNullable = false)]
        public string? Password { get; set; }

        /// <summary>
        /// 电子邮件地址,最大长度50个字符,不可为空
        /// </summary>
        [SugarColumn(Length = 50, IsNullable = false)]
        public string? Email { get; set; }

        /// <summary>
        /// 用户注册日期，不可为空
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// 用户状态，最大长度20个字符，不可为空
        /// </summary>
        [SugarColumn(Length = 20, IsNullable = false)]
        public string? UserStatus { get; set; }

        /// <summary>
        /// 用户信息更新时间，可为空
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 用户会员到期时间，可为空
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime? Member { get; set; }
    }


}
