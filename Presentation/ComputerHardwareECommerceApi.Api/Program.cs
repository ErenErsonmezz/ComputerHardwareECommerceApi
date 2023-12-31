
using ComputerHardwareECommerceApi.Infrastructure;
using ComputerHardwareECommerceApi.Persistence;
using ComputerHardwareECommerceApi.Application;
using ComputerHardwareECommerceApi.Application.Validators.ProductDtoValidators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http.Features;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureService();
builder.Services.AddPersistenceService();
builder.Services.AddApplicationService();
builder.Services.AddCors(options => options.AddPolicy("addCorsPolicy", policy =>
{
    policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials(); ;
}));

builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<ProductCreateDtoValidator>();
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 60000000; // Gerekirse boyutu ayarlayabilirsiniz
    options.MemoryBufferThreshold = int.MaxValue;
    options.BufferBody = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("addCorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
