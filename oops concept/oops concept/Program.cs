using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class class1
{
    private int num1 = 50;
    private int num2 = 100;
    public void average()
    {
        int avg=(num1+ num2)/2;
        Console.WriteLine("The average is "+avg);
    }
}
class Program
{
    static void Main(String[] args)
    {
        class1 obj = new class1();
        obj.average();
        Console.WriteLine();
    }
}