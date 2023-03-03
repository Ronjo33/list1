using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumnaOburnati4isla2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            num.Reverse();
            int sum = 0;
            for (int i = 0; i < num.Count; i++)
            {
                int currNum = num[i];
                int reversedNum = 0;
                while (currNum > 0)
                {
                    reversedNum = reversedNum * 10 + currNum % 10;
                    currNum /= 10;
                }
                sum += reversedNum;
            }
            Console.WriteLine(sum);
        }
    }
}
