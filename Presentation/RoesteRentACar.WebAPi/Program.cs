using RoesteRentACar.Application.Features.CQRS.Handlers.AboutHandlers;
using RoesteRentACar.Application.Features.CQRS.Handlers.BannerHandlers;
using RoesteRentACar.Application.Features.CQRS.Handlers.BrandHandlers;
using RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Persistence.Context;
using RoesteRentACar.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RentACarDbContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<AddAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<DeleteAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<AddBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<DeleteBannerCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<AddBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<DeleteBrandCommandHandler>();

builder.Services.AddScoped<GetVehicleQueryHandler>();
builder.Services.AddScoped<GetVehicleWithDetailQueryHandler>();
builder.Services.AddScoped<GetVehicleByIdQueryHandler>();
builder.Services.AddScoped<AddVehicleCommandHandler>();
builder.Services.AddScoped<UpdateVehicleCommandHandler>();
builder.Services.AddScoped<DeleteVehicleCommandHandler>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
