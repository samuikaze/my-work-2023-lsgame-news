using LSGames.News.Api.ServiceProviders;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

SwaggerDefinitionServiceProvider.ConfigureSwagger(builder.Services);
ServiceMapperProvider.GetServiceProvider(builder.Services);
DatabaseServiceProvider.AddDatabaseContext(builder.Services, builder.Configuration);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

// 由於展示需要，這邊也開放正式機上顯示 Swagger
app.UseSwagger(config =>
{
    config.PreSerializeFilters.Add((swaggerDoc, httpRequest) =>
    {
        string path = httpRequest.Path.ToString().Replace("/swagger/v1/swagger.json", "");
        swaggerDoc.Servers = new List<OpenApiServer> {
            new OpenApiServer { Url = $"{httpRequest.Scheme}://{httpRequest.Host.Value}{path}" }
        };
    });
});
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
