using System;
class Program
{
    public void display()
    {
        Console.WriteLine("This is an example code for functions in C#");
    }
    public void message()
    {
        Console.WriteLine("Non parameterized function!");
    }
    public static void Main(String[] args)
    {
        Program obj=new Program();
        obj.display();
        obj.message();
    }
}