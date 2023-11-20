//Static
//Not owned by instance
//Created when program Run
class Program
{
    static void Main()
    {
    	Car a = new();
	    Car b = new();
	    Console.WriteLine(Car.count);
    }
}

class Car {
	public static int count = 0;
	public Car() {
		count ++;
	}
	
}
