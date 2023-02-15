using SqlSugar;

namespace NovelSite.Expand
{
    public static class SqlsugarSetup
    {
        public static void AddSqlsugarSetup(this IServiceCollection services, string dbName = "SystemData")
        {
            var dbpath = $"{AppDomain.CurrentDomain.BaseDirectory}{dbName}.db";
            if (!File.Exists(dbpath))
            {
                Console.WriteLine(dbpath + " 文件不存在");
            }

            SqlSugarScope sqlSugar = new SqlSugarScope(new ConnectionConfig()
            {
                DbType = SqlSugar.DbType.Sqlite,
                ConnectionString = $"DataSource={dbName}.db",
                IsAutoCloseConnection = true,
            },
            db =>
            {
                db.Aop.OnLogExecuting = (sql, pars) =>
                {
                    Console.WriteLine(sql);//输出sql
                };
            });
            services.AddSingleton<ISqlSugarClient>(sqlSugar);//这边是SqlSugarScope用AddSingleton
        }
    }
}
