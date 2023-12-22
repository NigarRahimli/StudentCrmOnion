using StudentCrm.Persistence;
using StudentCrm.Application.DependencyResolver;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//bax
//app.UseExceptionHandler(c => c.Run(async context =>
//{
//    var exception=context.Features.Get<>
//}));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
