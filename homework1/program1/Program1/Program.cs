using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class program1
{
    public static void Main(string[] args)
    {
        string n = "";
        int a = 0, b = 0;
        Console.Write("Please input the first number: ");
        n = Console.ReadLine();
        a = Int32.Parse(n);
        Console.Write("Please input the second number: ");
        n = Console.ReadLine();
        b = Int32.Parse(n);
        Console.WriteLine("You have entered:" + a + " and " + b);
        int s = a * b;
        Console.WriteLine("and their product is: " + s);
    }
}