using System;
class Program
{
    public void addition(int a, int b)
    {
        Console.WriteLine("The sum is " + (a + b));
    }
    public void subtraction(int a, int b)
    {
        Console.WriteLine("The difference is " + (a - b));
    }
    public void multiplication(int a, int b)
    {
        Console.WriteLine("The product is " + (a * b));
    }
    public void division(int a, int b)
    {
        Console.WriteLine("The result is " + (a / b));
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the choice: 1.Add 2.Subtract 3.Multiply 4.Divide");
        int ch=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the values of a and b");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Program obj = new Program();
        switch (ch)
        {
            case 1:
                obj.addition(a, b); break;
            case 2:
                obj.subtraction(a, b); break;
            case 3:
                obj.multiplication(a, b); break;
            case 4:
                obj.division(a, b); break;
            default:
                Console.WriteLine("Recheck the entered operator");
                break;

        }
        
    }
}