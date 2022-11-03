using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("EmployeeDBConnection");

builder.Services.AddDbContextPool<AppDbContext>(db => db.UseSqlServer(connectionString));

builder.Services.AddMvc(options => options.EnableEndpointRouting = false).AddXmlSerializerFormatters();
builder.Services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();

var app = builder.Build();

app.UseStatusCodePagesWithReExecute("/Error/{0}");

app.UseStaticFiles();
app.UseMvc(routes =>
{
    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
});

//app.UseRouting();

app.Run();
