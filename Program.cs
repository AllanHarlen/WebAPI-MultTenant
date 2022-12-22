using AntaresAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Injeção de Depêndencia Multiplos DBContext.
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<AntaresContext>(provedor =>
{
    var http = provedor.GetService<IHttpContextAccessor>();
    var clientename = http.HttpContext.Request.Path.Value.Split("/", StringSplitOptions.RemoveEmptyEntries)[0];
    var connectionStringss = builder.Configuration.GetConnectionString(clientename);

    var opt = new DbContextOptionsBuilder<AntaresContext>();
    opt.UseMySql(ServerVersion.AutoDetect(connectionStringss));
    return new AntaresContext(opt.Options, builder.Configuration, clientename);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
