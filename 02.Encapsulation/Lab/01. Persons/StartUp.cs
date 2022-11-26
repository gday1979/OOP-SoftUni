using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int lines=int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                Person person = new Person(cmdArg[0], cmdArg[1], int.Parse(cmdArg[2]));
                persons.Add(person);
            }
            persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
