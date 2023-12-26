using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        // FootballPlayer player1 = new FootballPlayer { Name = "Atep", Club = "Persib", Age = 30};
        // FootballPlayer player2 = new FootballPlayer { Name = "Kevin D.B.", Club = "Manchester City", Age = 30};
        // FootballPlayer player3 = new FootballPlayer { Name = "Garnacho", Club = "Manchester United", Age = 30};

        // List<FootballPlayer> footballPlayers = new();
        // footballPlayers.Add(player1);
        // footballPlayers.Add(player2);
        // footballPlayers.Add(player3);

        XmlSerializer serializer = new XmlSerializer(typeof(List<FootballPlayer>));
        // // Serializer
        // using (StreamWriter writer = new StreamWriter("football_player.xml"))
        // {
        //     serializer.Serialize(writer, footballPlayers);
        // }
    

        // Deserializer
        List<FootballPlayer> deserializedFootballPlayers;
        using (StreamReader reader = new StreamReader("football_player.xml"))
        {
            deserializedFootballPlayers = (List<FootballPlayer>) serializer.Deserialize(reader);
        }

        foreach (var player in deserializedFootballPlayers)
        {
            Console.WriteLine($"{player.Name} ({player.Club})");
        }
    }
}

// public class Piece: ISame
// {
//     public string? Name {get; set;}
//     public string? Club {get; set;}
//     public int Age {get; set;}
// }

public class FootballPlayer
{
    public string? Name {get; set;}
    public string? Club {get; set;}
    // public int Age {get; set;}
    public int Stats {get; set;}
}

// public interface ISame
// {
//     public string? Name {get; set;}
//     public string? Club {get; set;}
//     public int Age {get; set;}
// }