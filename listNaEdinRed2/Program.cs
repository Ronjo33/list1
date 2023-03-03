using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listNaEdinRed2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4isla:");
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"nums[{i}] = {nums[i]}");
            }
        }
    }
}
