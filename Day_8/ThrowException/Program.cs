class Program
{
    static void Main()
    {
        Controller controller = new();
        // Avoid exception
        // if (controller.Contain(p))
        //     controller.AddCard(p, c);
    }
}



class Controller {
	private Dictionary<IPlayer, HashSet<ICard>> _players;
	
	public bool Contain(IPlayer p) {
		return _players.ContainsKey(p);
	}
	public bool AddCard(IPlayer p, ICard card) {
		if (!_players.ContainsKey(p)) {
			throw new InvalidDataException("No player was found");
		}
		return true;
	}
}
public interface IPlayer { }
public interface ICard { }