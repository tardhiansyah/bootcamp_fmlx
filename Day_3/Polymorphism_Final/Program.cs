using Polymorphism_Final;

class Program
{
    static void Main()
    {
        Transmission manual = new();
        ElectricEngine ee = new();
        HydroEngine he = new();
        Engine e = new();
        

        // * Check comment pada bagian Car class utk ubah output car.Run
        Car car = new Car(e, manual);
        car.Run();

        e = ee;
        Car car2 = new Car(ee, manual);
        car2.Run();
        
        // ! Error because HydroEngine isn't same type as Engine and their derivatives
        // Car car3 = new Car(he, manual);
    }
}