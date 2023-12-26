using Encapsulation;

class Program           // Internal
{
    string _programName = "Encapsulation";      // Private

    static void Main()  // Private
    {
        // Create instances
        Sedan mySedan = new Sedan("Toyota", "Black", 8);

        // Set name
        mySedan.SetName("Corolla");
        
        // Start the car
        mySedan.CarStart();
    }
}