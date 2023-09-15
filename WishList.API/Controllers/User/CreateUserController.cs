using Microsoft.AspNetCore.Mvc;
using WishList.API.RestModels;
using WishList.PostgreSQL.Commands.User.Create;

namespace WishList.API.Controllers.User;

[ApiController]
[Route("users")]
[ApiExplorerSettings(GroupName = "users")]
public sealed class CreateUserController : ControllerBase
{
    // add command to validate user
    private readonly ICreateUserCommand _createUser;

    public CreateUserController(ICreateUserCommand createUser)
    {
        _createUser = createUser;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest request)
    {
        // validate user
        // handle user validation result

        CreateUserDto dto = new CreateUserDto();
        await _createUser.Execute(dto);
        
        return Ok();
    }
}