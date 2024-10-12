using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WLogestic.Api.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<WLogesticDBContex>(op=>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("connectionString"));
} );
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
