namespace WishList.API;

public sealed class ApiAuthTokenMiddleware
{
    private const double MinutesDeltaToRefresh = 30;
    private const string ServiceName = "Server";

    private readonly RequestDelegate m_next = default;


    public ApiAuthTokenMiddleware(RequestDelegate next)
    {
        m_next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        await m_next(context);
        // some logic

    }
}