namespace Polymorphism_Final;

public class Car
{
    // * Define engine and transmission class
    private Engine _engine;
    private Transmission _transmission;

    public Car(Engine engine, Transmission transmission)
    {
        _engine = engine;
        _transmission = transmission;
    }

    public void Run()
    {
        // * Add transmission check
        _transmission.Check();

        
        // ? Kalau pake Method Hiding yang ke panggil parent-nya?
        //   Soalnya yang di definisikan pada constructor itu parentnya (si Engine).
        // ? Terus kalau yg dipake di constructor itu childnya gimana?
        //   Ya.. udah pasti yang muncul si Child, Tapi.. nanti di Main() si constructor Car
        //   gak bisa dikasih parameter si Parent (Engine)

        // ? Kalau pake Overriding yang ke panggil child-nya?
        //   Karena Overriding akan mentakeover Method parent-nya
        
        // * Add engine start
        _engine.Start();

        _engine.Start(1);
    }




    // ! BAD PRACTICES, ERROR
    // private ElectricEngine _eengine;
    // public Car(ElectricEngine engine, Transmission transmission)
    // {
    //     _eengine = engine;
    //     _transmission = transmission;
    // }

    // public Car(Engine engine, Transmission transmission)
    // {
    //     _engine = engine;
    //     _transmission = transmission;
    // }

    // public void Run()
    // {
    //     // * Add transmission check
    //     _transmission.Check();

    //     // * Add engine start
    //     _engine.Start();
    //     _eengine.Start();
    // }
}
