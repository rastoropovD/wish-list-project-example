using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.Controllers;
using WishList.API.RestModels.Validators;
using WishList.PostgreSQL.Extensions;
using WishList.PostgreSQL.Extensions.CQRS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder
    .Services
    .AddValidators()
    .AddWishListData("USER ID=postgres;Password=admin;Server=localhost;Port=5432;Database=wish-list-db;Integrated Security=true;Pooling=true")
    .AddDataAccess()
    .AddSQRS();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.TagActionsBy(api =>
    {
        if (api.GroupName != null)
        {
            return new[] { api.GroupName };
        }
        
        if (api.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
        {
            return new[] { controllerActionDescriptor.ControllerName };
        }
        
        throw new InvalidOperationException("Unable to determine tag for endpoint.");
    });
    
    options.DocInclusionPredicate((name, api) => true);
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