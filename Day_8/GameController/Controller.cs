using Microsoft.Win32.SafeHandles;

namespace GameController;

class Controller
{
    // Custom delegete
    public delegate void PlayerCreatedEventHandler(IPlayer player);
    public event PlayerCreatedEventHandler NewPlayerCreated = null!;
    // Action
    public event Action<ICard, CardStatus> CardStatusUpdated = null!;


    private readonly Dictionary<IPlayer, HashSet<ICard>> _players;
    private readonly HashSet<ICard> _deckCards;


    public Controller()
    {
        _players = new();       // Kosongan
        _deckCards = new();     // Kosongan
    }

    public void AddPlayer(params IPlayer[] players)
    {
        if (_players.Count == 4)
        {
            return;
        }

        foreach (var player in players)
        {
            if (!_players.ContainsKey(player) && _players.Count < 4)
            {
                _players.Add(player, new HashSet<ICard>());
                OnAddedPlayer(player);
            }
        }  
    }

    public void AddCardToDeck(params ICard[] cards)
    {

    }

    public bool AddCard(IPlayer player, params ICard[] cards)
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

    protected virtual void OnAddedPlayer(IPlayer player)
    {
        NewPlayerCreated?.Invoke(player);
    }

    protected virtual void OnChangedCardStatus(ICard card, CardStatus status)
    {
        card.Status = status;
        CardStatusUpdated?.Invoke(card, status);
    }
}   