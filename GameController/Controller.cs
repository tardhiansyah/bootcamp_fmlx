using Microsoft.Win32.SafeHandles;

namespace GameController;

class Controller
{
    // Custom delegete
    public delegate void PlayerCreatedEventHandler(IPlayer player);
    public event PlayerCreatedEventHandler playerCreated;
    // Action
    public event Action<INumberCard, CardStatus> cardStatusUpdated;


    private Dictionary<IPlayer, HashSet<INumberCard>> _players;
    private HashSet<INumberCard> _deckCards;


    public Controller(IPlayer player1, IPlayer player2)
    {
        _players = new();       // Kosongan
        _deckCards = new();     // Kosongan
        _players.Add(player1, new HashSet<INumberCard>());
        _players.Add(player2, new HashSet<INumberCard>());
    }

    public bool AddCard(IPlayer player, params INumberCard[] cards)
    {
        if(!_players.ContainsKey(player))
            return false;
        
        foreach (var card in cards)
        {
            _players[player].Add(card);
            OnChangedCardStatus(card, CardStatus.OnPlayer);
        }
        return true;  
    }

    protected virtual void OnChangedCardStatus(INumberCard card, CardStatus status)
    {
        card.Status = status;
        cardStatusUpdated.Invoke(card, status);
    }
}   