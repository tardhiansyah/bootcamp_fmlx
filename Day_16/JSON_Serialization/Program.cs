using System.Runtime.CompilerServices;
using System.Text.Json;

public class Person
{
    public string Name {get; set; }
    public int Age { get; set; }
    public List<string> myList {get; set;}
}

public class MyPerson
{
    public string Name {get; set;}
    public int Age {get; set;}
    public List<string> myList {get; set;}
}

class Program
{
    static void Main()
    {
        Person person1 = new Person() {Name = "Robi", Age = 15, myList = new List<string>()};
        Person person2 = new Person() {Name = "Daud", Age = 35, myList = new List<string>()};

        List<Person> persons = new List<Person>();
        persons.Add(person1);
        persons.Add(person2);

        string jsonString = JsonSerializer.Serialize(persons);

        using (StreamWriter writer = new StreamWriter("person.json"))
        {
            writer.Write(jsonString);
        }


        string jsonFromFile;
        using (StreamReader reader = new StreamReader("person.json"))
        {
            jsonFromFile = reader.ReadToEnd();
        }

        List<MyPerson> deserializedPersons = JsonSerializer.Deserialize<List<MyPerson>>(jsonFromFile);
        foreach (var person in deserializedPersons)
		{
			Console.WriteLine($"Deserialized Person: {person.Name}, {person.Age}");
		}

    }
}