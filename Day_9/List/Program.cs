using System.Collections;
using System.Security;

class Program
{
    static void Main()
    {
        List<int> myInt = new();
        myInt.Add(3);
        myInt.Add(4);
        myInt.Add(5);

        int result = myInt[2];
        Console.WriteLine(result);

        List<int> myInt2 = new() {1, 2, 3, 4, 5};
        myInt2.Add(6);
        Console.WriteLine(myInt2[5]);

        List<Player> players = new()
        {
            new Player(1, "Taufik"),
            new Player(2, "Ardhi"),
            new Player(3, "Ruby")
        };

        // Check if player in list
        //var checkResult = players.FindIndex(p => p.Name == "Ruby");
        var checkResult = FindPlayer(players, "Arhi");
        Console.WriteLine(checkResult);
    }

    static int FindPlayer(List<Player> p, string name)
    {
        return p.FindIndex(p => p.Name == name);
    }
}


class Player
{
    public int Id { get; }
	public string Name { get; }
	public Player(int id,string name) 
	{
		Id = id;
		Name = name;	
	}
}