using Microsoft.AspNetCore.Mvc;
using WishList.API.RestModels.User;
using WishList.API.RestModels.User.Create;
using WishList.PostgreSQL.CQRS.User.Queries.FindUser;
using WishList.PostgreSQL.MediatorImpl;

namespace WishList.API.Controllers.User;

[ApiController]
[Route("users")]
[ApiExplorerSettings(GroupName = "users")]
public sealed class FindUserController : ControllerBase
{
    private readonly IMediator _mediator;

    public FindUserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    
}