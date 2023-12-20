//Implement properties get;private set; for interfaces

class Program
{
    static void Main()
    {
        GameController gc = new();
        // gc.MyProp = 3;  // Set di private
        Console.WriteLine(gc.MyProp);
        gc.X();
    }
}

public interface IGameController {
	//public int x; We cant declare variable inside interface
	void X();
	int MyProp {get;}
}
public class GameController : IGameController
{
	public int MyProp { get; private set; }

	public void X()
	{
        //
	}
}