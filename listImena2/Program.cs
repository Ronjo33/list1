using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listImena2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi imena");
            List<string> name = Console.ReadLine().Split(',').ToList();           
            foreach (string nam in name)
            {
                string[] mas = nam.Trim().Split(' ');
                Console.WriteLine($"{mas[1]} {mas[0]}");
        }   }
    }
}
