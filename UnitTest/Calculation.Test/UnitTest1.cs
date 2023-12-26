using Calculation;
namespace Calculation.Test;

[TestFixture]
public class NumberCalculationTests
{
    private NumberCalculation numberCalculation;


    [SetUp]
    public void Setup()
    {
        numberCalculation = new NumberCalculation();
    }

    [TestCase(5, 4, 9)] //[Fact]
    [TestCase(2, 3, 5)]
    [TestCase(6, 1, 7)]
    [TestCase(0, 0, 0)]
    public void Add_ReturnCorrectNumber_AdditionOfTwoNumber(int a, int b, int expected)
    {
        //Arrange

        //Act
        int actual = numberCalculation.Add(a, b);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [Ignore("Ignore this test")]
    public void Substract_ReturnCorrectNumber_SubstractionOfTwoNumber()
    {
        //Arrange
        int a = 10;
        int b = 12;
        int expected = -2;

        //Act
        int actual = numberCalculation.Subtract(a, b);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase (5, 5, 25)]
    [TestCase (5, -5, -25)]
    [TestCase (-5, 5, -25)]
    [TestCase (0, 5, 0)]
    [TestCase (0, -5, 0)]
    [TestCase (0, 0, 0)]
    public void Multiply_ReturnCorrectNumber_MultiplicationOfTwoNumber(int a, int b, int expected)
    {
        //Arrange

        //Act
        int actual = numberCalculation.Multiply(a, b);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase (5, 5, 1)]
    [TestCase (5, -5, -1)]
    [TestCase (-5, 5, -1)]
    [TestCase (0, 5, 0)]
    [TestCase (0, -5, 0)]
    public void Divide_ReturnCorrectNumber_DivisionOfTwoNumber(int a, int b, int expected)
    {
        //Arrange

        //Act
        int actual = numberCalculation.Divide(a, b);
        
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [TestCase (0, 0)]
    [TestCase (-5, 0)]
    [TestCase (5, 0)]
    public void Divide_ShouldThrowDivideByZeroException_DivideByZero(int a, int b)
    {
        //Arrange

        //Act

        //Assert
        Assert.Throws<DivideByZeroException>( () => numberCalculation.Divide(a, b));
    }
}