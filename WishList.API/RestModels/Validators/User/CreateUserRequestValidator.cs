using FluentValidation;

namespace WishList.API.RestModels.Validators.User;

public sealed class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserRequestValidator()
    {
        RuleFor(r => r.FirstName)
            .NotNull()
            .NotEmpty()
            .WithMessage("First name is required");
        
        RuleFor(r => r.LastName)
            .NotNull()
            .NotEmpty()
            .WithMessage("Last name is required");
    }
}