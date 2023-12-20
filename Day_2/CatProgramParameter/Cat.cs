namespace Animal;

public class Cat
{	
	private string _name = "";
	private int _age;
	private float _weight;
	
	// Ini operator overloading
	public Cat() {}
	public Cat(string name, int age, float weight)
	{
		this.SetAge(age);
		this.SetWeight(weight);
		this.SetName(name);
	}

	// Setter
	public void SetName(string name)
	{
		this._name = name;
	}
	public void SetAge(int age)
	{
		this._age = age;
	}
	public void SetWeight(float weight)
	{
		this._weight = weight;
	}
	
	// Getter
	public string GetName()
	{
		return this._name;
	}
	public int GetAge()
	{
		return this._age;
	}
	public float GetWeight()
	{
		return this._weight;
	}
	
	public string GetInformation()
	{
		return $"Cat Info. Name: {this.GetName()}, Age: {this.GetAge()}, Weight: {this.GetWeight()}";
	}

	public void Eat(string food)
	{
		Console.WriteLine($"{this._name} eating {food}");
	}
	public void Meow()
	{
		Console.WriteLine("Meowww");
	}
}
