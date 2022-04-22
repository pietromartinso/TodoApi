using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseKestrel()
    .UseContentRoot(Directory.GetCurrentDirectory())
    .UseIISIntegration();

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnectionString"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

}

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
