using FluentValidation;
using WishList.API.RestModels.User;
using WishList.API.RestModels.User.Create;
using WishList.API.RestModels.Validators.User;

namespace WishList.API.RestModels.Validators;

public static class ValidatorsInstaller
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services
            .AddScoped<IValidator<CreateUserRequest>, CreateUserRequestValidator>();
        
        return services;
    }
}