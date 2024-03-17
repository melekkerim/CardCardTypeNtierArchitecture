using CardCardTypeNtierArchitecture.BLL.Abstract;
using CardCardTypeNtierArchitecture.BLL.Concrete;
using CardCardTypeNtierArchitecture.DAL.Abstract;
using CardCardTypeNtierArchitecture.DAL.Concrete;
using CardCardTypeNtierArchitecture.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICardRepository, CardRepository>();// scoped, transient, singleton
builder.Services.AddScoped<ICardService, CardService>();
builder.Services.AddAutoMapper(typeof(AutomapperProfiles));
builder.Services.AddScoped<ICardTypeRepository, CardTypeRepository>();
builder.Services.AddScoped<ICardTypeService, CardTypeService>();

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
