using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.DataContracts;
using System.Runtime.Serialization.Json;

class Program
{
    static void Main()
    {
        var p = new Person("ZJohn", 123, Code.Error);
		var p2 = new Person("Yusuf", 444, Code.Safe);

        List<Person> people = new();
		people.Add(p);
		people.Add(p2);

        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>));
        using (FileStream stream = new FileStream("person.json", FileMode.OpenOrCreate))
        {
            serializer.WriteObject(stream, people);
        }

        List<Person> importPerson;

        using (FileStream stream = new FileStream("person.json", FileMode.Open))
        {
            importPerson = (List<Person>) serializer.ReadObject(stream);
        }

        foreach (var person in importPerson)
        {
            Console.WriteLine(person.age);
        }
    }
}

public enum Code
{
    Safe,
    Error
}

[DataContract]
public class Person
{
    [DataMember]
    private string Name;

    [DataMember]
    internal int age;

    [DataMember]
    private Code code;

    public Person(string name, int age, Code code)
    {
        this.Name = name;
        this.age = age;
        this.code = code;
    }

    public string GetName()
	{
		return Name + " " + (int)code;
	}
}