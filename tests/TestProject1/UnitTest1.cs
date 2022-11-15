using Math = ConsoleApp1.Math;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Math_Sum_3_4_7_returns()
    {
        int expected = 7;
        
        int result = Math.Sum(3, 4);
        
        Assert.AreEqual(expected, result);
    }
}