using Blog.Data;
using blogapi.Controller;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogDataContext>();
 builder.Services.AddTransient<TokenService>();
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
