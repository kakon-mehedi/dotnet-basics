using dotnet_fundamentals_kakon.Games.Controllers;

namespace dotnet_fundamentals_kakon.Routes;

public static class GamesRoutes
{
    public static RouteGroupBuilder MapGameEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/games");
        
        group.MapGet("/", GameControllers.GetGames );
        group.MapGet("/total-users", GameControllers.GetTotalUsers);

        return group;
    }
}