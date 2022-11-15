namespace ConsoleApp1;

public static class Math
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Div(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }

        return a / b;
    }
}