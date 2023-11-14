class Program
{
	static void Main()
	{
		Console.WriteLine("Hello Cat!");
		
		Cat kuro = new Cat();
	}
}

class Cat
{
	public string colour;
	public int age;
	public float weight;
	
	public void Meow(int times)
	{
		for (int i = 0; i < times; i++)
		{
			Console.WriteLine("Meow..");
		}
	}
}