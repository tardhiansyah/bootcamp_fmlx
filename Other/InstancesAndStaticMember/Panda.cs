public class Panda
{
    public string name;     // Instance field
    public static int population;

    public Panda(string name)
    {
        this.name = name;
        population++;
    }
}