using GameController;

class Program
{
    static void Main()
    {
        UI ui = new();
        DataBase db = new();

        var player1 = new Player(100, "Taufik");
        var player2 = new Player(1001, "Ardhi");

        Controller controller = new Controller(player1, player2);
        controller.cardStatusUpdated += ui.CardUpdated;
        controller.cardStatusUpdated += db.LogToDB;
        // controller.playerCreated += db.LogToDB;

        NumberCard card1 = new(1, 1, CardColor.Blue);
        NumberCard card2 = new(1, 1, CardColor.Green);
        NumberCard card3 = new(1, 1, CardColor.Yellow);

        controller.AddCard(player1, card1, card2);
    }   
}
