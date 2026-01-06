public class Calculator : ICalculator
{
    public double AddNumbers(double a, double b)
    {
        return a + b;
    }

    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public double DivideNumbers(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }

    public double MultiplyNumbers(double a, double b)
    {
        return a * b;
    }

    public double SubtractNumbers(double a, double b)
    {
        return a - b;
    }

    public int SubtractNumbers(int a, int b) => a - b;

    public double GetFaculty(double n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * GetFaculty(n - 1);
        }
    }
}