// using Animal;
using Transportation;

class Program
{
	static void Main()
	{
		Animal.Cat kuro = new Animal.Cat();
		kuro.isMale = true;
		kuro.color = "Black";
		kuro.Meow();
		
		Animal.Dog rock = new Animal.Dog();
		rock.isMale = false;
		rock.color = "Brown";
		rock.Bark();
		
		Car jazz = new Car();
		jazz.brand = "Honda";
		jazz.Go();
	}
}