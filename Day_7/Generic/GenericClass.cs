using System.Numerics;

class GenericClass<TMsg, TNumber>
    where TMsg: struct
    where TNumber: INumber<TNumber>
{
    private TMsg _genericVariable;

    // Constructor
    public GenericClass(TMsg genericParameter)
    {
        _genericVariable = genericParameter;
    }

    public TMsg GenericMethod(TNumber genericParameter)
    {
        Console.WriteLine($"Param type: {typeof(TNumber)}, Param value: {genericParameter}");
        Console.WriteLine($"Return type: {typeof(TMsg)}, Param value: {_genericVariable}");
        return _genericVariable;
    }

    public TNumber GenericProperty { get; set; }
}
