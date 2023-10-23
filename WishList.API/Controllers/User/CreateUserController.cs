using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using WishList.API.RestModels;
using WishList.API.RestModels.User;
using WishList.API.RestModels.User.Create;
using WishList.PostgreSQL.CQRS.User.Commands.Create;
using WishList.PostgreSQL.CQRS.User.Queries.FindUser;
using WishList.PostgreSQL.Dtos.User;
using WishList.PostgreSQL.MediatorImpl;

namespace WishList.API.Controllers.User;

[ApiController]
[Route("users")]
[ApiExplorerSettings(GroupName = "users")]
public sealed class CreateUserController : ControllerBase
{
    private readonly IValidator<CreateUserRequest> _validator;
    private readonly IMediator _mediator;
    private readonly ILogger<CreateUserController> _logger;

    public CreateUserController(
        IValidator<CreateUserRequest> validator,
        IMediator mediator,
        ILogger<CreateUserController> logger)
    {
        _validator = validator;
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost("create")]
    public async Task<ActionResult<CreateUserResponse>> Create([FromBody] CreateUserRequest request)
    {
        ValidationResult validationResult = await _validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors
                .Select(e => new {e.PropertyName, e.ErrorMessage}));
        }

        string passwordHash = ""; // todo: process password hashing

        try
        {
            CreateUserCommand createUserCommand = new CreateUserCommand(
                request.FirstName,
                request.LastName,
                request.Email,
                passwordHash);

            await _mediator.Send(createUserCommand);

            UserInfoDto? userInfo = await _mediator.Send<FindUserQuery, UserInfoDto?>(new FindUserQuery(request.Email));

            if (userInfo != null)
            {
                CreateUserResponse response = new CreateUserResponse(
                    userInfo.Id,
                    userInfo.FirstName,
                    userInfo.LastName,
                    userInfo.Email,
                    "");

                return Ok(response);
            }
            else
            {
                _logger.LogError($"Could not find user after creations");

                return BadRequest();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,$"Error occured during the user creation process");
            
            return Problem("Something went wrong");
        }
    }
}