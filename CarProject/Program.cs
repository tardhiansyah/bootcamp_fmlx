using CarComponent;

class Program
{
    static void Main()
    {
        // Create car component instances
        Engine petrolEngine = new Engine(4, "suzuki");
        Engine dieselEngine = new Engine(6, "isuzu");
        Door carDoor = new Door("black", 4, 10);
        Tire tire = new Tire(18, "Yokohama");


        // Create car instances
        Car car = new Car(petrolEngine, carDoor, tire, "Jazz");
        Console.WriteLine(car.name);
        car.Start();

        Car car2 = new Car();
        car2.engine = petrolEngine;
        car2.door = carDoor;
        car2.tire = tire;
        car2.name = "Panther";
        Console.WriteLine("\n" + car2.name + ", Engine brand " + car2.EngineBrandCheck());
        car2.Start();

        Car car3 = new Car()
        {
            engine = petrolEngine,
            door = carDoor,
            tire = tire,
            name = "Corolla"
        };
        // Bad practices, it's not implement encapsulation!
        Console.WriteLine("\n" + car3.name + ", Engine brand " + car3.engine.brand);
        car3.Start();
    }
}