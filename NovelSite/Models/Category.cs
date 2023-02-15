using SqlSugar;
using System.Security.Principal;

namespace NovelSite.Models
{
    public class Category
    {
        /// <summary>
        /// 分类ID，自增主键，唯一标识一个分类
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int CategoryId { get; set; }

        /// <summary>
        /// 父级ID，标识该分类的父级分类
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int ParentId { get; set; }

        /// <summary>
        /// 分类名称，分类的名称
        /// </summary>
        [SugarColumn(Length = 50, IsNullable = false)]
        public string? CategoryName { get; set; }

        /// <summary>
        /// 分类描述，对该分类的简要描述
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? CategoryDescription { get; set; }
    }
}
