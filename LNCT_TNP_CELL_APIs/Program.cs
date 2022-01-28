using DemoApiUsingJWT.Repository;
using DemoApiUsingJWT.Repository.Implementation;
using DemoApiUsingJWT.Service;
using DemoApiUsingJWT.Service.Implementation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IAdminRepository, AdminRepository>();
builder.Services.AddSingleton<IAdminService, AdminService>();
builder.Services.AddSingleton<IStudentsProfileRepository, StudentsProfileRepository>();
builder.Services.AddSingleton<IStudentsProfileService, StudentsProfileService>();
builder.Services.AddSingleton<IStudentAcademicRepository, StudentAcademicRepository>();
builder.Services.AddSingleton<IStudentAcademicService, StudentAcademicService>();
builder.Services.AddSingleton<IAskQueryRepository, AskQueryRepository>();
builder.Services.AddSingleton<IAskQueryService, AskQueryService>();
builder.Services.AddSingleton<ILoginRepository, LoginRepository>();
builder.Services.AddSingleton<ILoginService, LoginService>();
builder.Services.AddSingleton<INewPostRepository, NewPostRepository>();
builder.Services.AddSingleton<INewPostService, NewPostService>();



builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(Option=>
{
    Option.RequireHttpsMetadata = false;
    Option.SaveToken = true;
    Option.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ClockSkew = TimeSpan.FromMinutes(2),
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(options =>
options.WithOrigins("https://localhost:7173/")
.AllowAnyMethod()
.AllowAnyHeader());
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

//app.MapControllers();

app.Run();


    