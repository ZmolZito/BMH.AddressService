using BMH.AddressService.Application;
using BMH.AddressService.Application.Dto;
using BMH.AddressService.Domain.Enum;
using BMH.AddressService.Infrastructure;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add Infrastructure services
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/validateaddress", async (IAddressService addressService, AddressInputDto address) =>
{
    if (address == null)
    {
        throw new ArgumentException("Addresse dto er tom");
    }

    var status = await addressService.ValidateAddress(address);

    return status switch
    {
        ValidStatus.Valid => Results.Ok("Valid"),
        ValidStatus.Invalid => Results.BadRequest("Invalid"),
    };
});



app.Run();