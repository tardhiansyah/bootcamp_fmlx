using GameController;

class Program
{
    static void Main()
    {
        var player1 = new Player(1000, "Taufik");
        var player2 = new Player(1001, "Ardhi");
        var player3 = new Player(1002, "Taufik");
        var player4 = new Player(1003, "Ardhi");
        var player5 = new Player(1004, "Ardhi");

        Controller controller = new();
        controller.NewPlayerCreated += UI.PlayerCreated;
        controller.NewPlayerCreated += DataBase.LogToDB;
        controller.CardStatusUpdated += UI.CardUpdated;
        controller.CardStatusUpdated += DataBase.LogToDB;

        controller.AddPlayer(player1, player2, player3, player4);

        NumberCard card1 = new(1, CardColor.Blue, 1);
        NumberCard card2 = new(1, CardColor.Green, 7);
        NumberCard card3 = new(1, CardColor.Yellow, 8);

        controller.AddCard(player1, card1, card2);
        controller.AddCard(player2, card3);
    }   
}
