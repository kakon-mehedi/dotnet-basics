using dotnet_fundamentals_kakon.Games.Data;

namespace dotnet_fundamentals_kakon.Games.Controllers;

public static class GameControllers
{
    public static List<Game> GetGames()
    { 
        GameList games = new GameList();
        return games.MyGames;

    }

    public static int GetAge()
    {
        return 30;
    }

    public static int GetTotalUsers()
    {
        return 30;
    }
}