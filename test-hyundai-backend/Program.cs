using Microsoft.EntityFrameworkCore;
using test_hyundai_backend.Data;
using test_hyundai_backend.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TaskContext>(opt => opt.UseInMemoryDatabase("TaskList"));
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
