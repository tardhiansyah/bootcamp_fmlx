using Animal;

class Program
{
	static void Main()
	{
		// Create instances cat1
		Cat cat1 = new Cat(age: 3, name: "kuro", weight: 2.5f);
		cat1.Eat("Whiskas");
		Console.WriteLine(cat1.GetInformation());
		
		// Create instances cat2
		Cat cat2 = new Cat();
		Console.WriteLine(cat2.GetInformation());
		
		cat2.SetAge(1);
		cat2.SetName("ao");
		cat2.SetWeight(2.1f);
		
		Console.WriteLine(cat2.GetInformation());
		
		// Bisa juga gini tapi harus public variable age, name, weight nya
		// Cat cat3 = new Cat()
		// {
		// 	age = 4,
		// 	name = "don",
		// 	weight = 3.5f	
		// };
		
		
		
	}	
}