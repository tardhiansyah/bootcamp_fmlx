using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        int[] myArray = new int[10];
        int[] myArray2 = { 1, 2, 3, 4 };

        myArray[0] = 10;
        myArray[1] = 11;

        int sizeOfArray = myArray.Length;

        GameController game = new();
        Player player1 = new(1, "Taufik");
        Player player2 = new(2, "Ardhiansyah");
        Player player3 = new(3, "Taufik");

        game.AddPlayer(player1);
        game.AddPlayer(player2);
        game.AddPlayer(player3);

        Console.WriteLine(game.GetPlayer(0).Name);
    }
}


class GameController
{
    Player[] players;

    int count = 0;

    public GameController()
    {
        // Max 4 pemain
        players = new Player[4];
    }

    public bool AddPlayer(Player p)
    {
        players[count] = p;
        count++;
        return true;
    }

    public Player GetPlayer(int index)
    {
        return players[index];
    }
}

class Player
{
    public string Name { get; }
    public int Id { get; }
    public Player(int id, string name)
    {
        Name = name;
        Id = id;
    }
}