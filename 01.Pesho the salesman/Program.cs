using System;


namespace _01.Pesho_the_salesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ;
            double sum = 0;
            int countNumber = 0;
            string input=Console.ReadLine();
            while(true)
            {
               double days=double.Parse(input);
                sum += days;
                countNumber++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total:{sum}");
            Console.WriteLine($"Average:{sum / countNumber:f2} ");
        }
    }
}
