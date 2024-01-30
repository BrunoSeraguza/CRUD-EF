using System.Text;
using Blog.Data;
using blogapi.Controller;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

var key = Encoding.ASCII.GetBytes(Configuration.JwtToken);
builder.Services.AddAuthentication(x =>
{
   x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
   x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; 
}).AddJwtBearer(x=> {
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };

    
});


builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddTransient<TokenService>();
builder.Services.AddControllers();

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
