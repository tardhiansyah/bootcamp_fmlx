// * Predefined Type
string message = "Hello World";
string upperMessage = message.ToUpper();
Console.WriteLine(upperMessage);

int x  = 2022;
message = message + x.ToString();
Console.WriteLine(message);




// * Custom Type
// Instantiation
UnitConverter feetsToInches = new UnitConverter(12);
UnitConverter milesToFeet = new UnitConverter(5200);

// WriteLine dari class Control merupakan contoh static method
// Console merupakan static class. Jadinya gk bisa bikin instance dari class Console
// Console console = new Console();
// console.WriteLine();
Console.WriteLine(feetsToInches.Convert(1));
Console.WriteLine(milesToFeet.Convert(1));
Console.WriteLine(feetsToInches.Convert(milesToFeet.Convert(1)));


public class UnitConverter
{
    // ****** Data members (field) ******
    int ratio;

    // ****** Function members ******
    // * Constructor
    public UnitConverter(int unitRatio)
    {
        ratio = unitRatio;
    }

    // * Method
    public int Convert(int unit)
    {
        return unit * ratio;
    }
}