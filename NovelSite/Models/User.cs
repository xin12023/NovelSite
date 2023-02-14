using SqlSugar;

namespace NovelSite.Models
{
    public class User
    {
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int UserId { get; set; }

        [SugarColumn(Length = 50, IsNullable = true)]
        public string? Username { get; set; }

        [SugarColumn(Length = 32)]
        public string? Password { get; set; }

        [SugarColumn(Length = 100)]
        public string? Email { get; set; }

        [SugarColumn(IsNullable = false)]
        public DateTime RegisterDate { get; set; }

        [SugarColumn(Length = 20)]
        public string? UserStatus { get; set; }

        [SugarColumn(IsNullable = true)]
        public DateTime UpdateTime { get; set; }

        [SugarColumn(IsNullable = true)]
        public DateTime? Member { get; set; }
    }


}
