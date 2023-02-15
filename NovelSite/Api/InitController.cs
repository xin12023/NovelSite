using Microsoft.AspNetCore.Mvc;
using NovelSite.Models;
using SqlSugar;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NovelSite.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class InitController : ControllerBase
    {
        ISqlSugarClient db;
        public InitController(ISqlSugarClient db)
        {
            this.db = db;
        }

        // GET: api/<InitController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
 
                Console.WriteLine("创建数据库");
                db.DbMaintenance.CreateDatabase();
                //db.CodeFirst.InitTables(typeof(User));
                db.CodeFirst.SetStringDefaultLength(200).InitTables(typeof(User));
    
            return new string[] { "value1", "value2" };
        }
    }
}
