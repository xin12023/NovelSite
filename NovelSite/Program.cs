using NovelSite.Expand;

var builder = WebApplication.CreateBuilder(args);

//注册数据库连接单例
builder.Services.AddSqlsugarSetup("SystemData");

// Add services to the container.
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseAuthorization();

app.MapControllers();

app.Run();