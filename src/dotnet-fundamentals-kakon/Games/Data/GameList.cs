
namespace dotnet_fundamentals_kakon.Games.Data;

public class GameList

{
   public List<Game> MyGames { get; set; } = new List<Game>();
    
    public GameList()
    {
        var game1 = new Game("COC", 100);
        var game2 = new Game("Fifa", 400);

        MyGames.Add(game1);
        MyGames.Add(game2);
    }

}


