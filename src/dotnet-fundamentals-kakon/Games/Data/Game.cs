namespace dotnet_fundamentals_kakon.Games.Data;

public class Game
{
    public Game(string name, int totalUsers)
    {
        Name = name;
        TotalUsers = totalUsers;
    }

    private string Name { get; set; }
    private int TotalUsers  { get; set; }
}