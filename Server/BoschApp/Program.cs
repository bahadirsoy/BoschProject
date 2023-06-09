using BoschApp.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using BoschApp.DataAccessLayer;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Concrete;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Concrete;
using BoschApp.BusinessLayer.Rules;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<BusinessRules>();
builder.Services.AddScoped<IAlanRepository, AlanRepository>();
builder.Services.AddScoped<IAlanBusinessService, AlanBusinessService>();
builder.Services.AddScoped<IDepartmanRepository, DepartmanRepository>();
builder.Services.AddScoped<IDepartmanBusinessService, DepartmanBusinessService>();
builder.Services.AddScoped<IKisimRepository, KisimRepository>();
builder.Services.AddScoped<IKisimBusinessService, KisimBusinessService>();
builder.Services.AddScoped<IIstasyonRepository, IstasyonRepository>();
builder.Services.AddScoped<IIstasyonBusinessService, IstasyonBusinessService>();
builder.Services.AddScoped<IStokAlaniRepository, StokAlaniRepository>();
builder.Services.AddScoped<IStokAlaniBusinessService, StokAlaniBusinessService>();
builder.Services.AddScoped<IAltParcaRepository, AltParcaRepository>();
builder.Services.AddScoped<IAltParcaBusinessService, AltParcaBusinessService>();
builder.Services.AddScoped<IEnjektorRepository, EnjektorRepository>();
builder.Services.AddScoped<IEnjektorBusinessService, EnjektorBusinessService>();
builder.Services.AddScoped<ISiparisRepository, SiparisRepository>();
builder.Services.AddScoped<ISiparisBusinessService, SiparisBusinessService>();
builder.Services.AddScoped<IUretimRepository, UretimRepository>();
builder.Services.AddScoped<IUretimBusinessService, UretimBusinessService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
