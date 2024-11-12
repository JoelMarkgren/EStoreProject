using EStoreAPI.Data;
using EStoreAPI.Data.Interfaces;
using EStoreAPI.Data.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(
	options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowBlazorWasm", policy =>
	{
		policy.WithOrigins("https://localhost:7040") 
			  .AllowAnyMethod()
			  .AllowAnyHeader();
	});
});

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<ICellphoneRepository, CellphoneRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseCors("AllowBlazorWasm");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
