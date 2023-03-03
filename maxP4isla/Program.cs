using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxP4isla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vevedi 4isla:");
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxCount = 0;
            int maxNum = 0;
            int count = 1;

            for (int i = 0; i < num.Count - 1; i++)
            {
                if (num[i] == num[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxNum = num[i];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNum + " ");
            }
        }
    }
}
