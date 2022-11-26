using System;

namespace Pesho_theSalesMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double monday=double.Parse(Console.ReadLine());
            double tuesday=double.Parse(Console.ReadLine());
            double wednesday=double.Parse(Console.ReadLine());
            double thursday=double.Parse(Console.ReadLine());
            double friday=double.Parse(Console.ReadLine());
            double saturday=double.Parse(Console.ReadLine());
            double sunday=double.Parse(Console.ReadLine());
            double sum = monday + tuesday + wednesday + thursday + friday + saturday + sunday;
            double average = sum / 7;
            Console.WriteLine($"Total: {sum}");
            Console.WriteLine($"Average: {average:f3}");

        } 
    }
}
