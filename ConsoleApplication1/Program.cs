using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice1,dice2,sum=0;
            int[] sumArray = new int[11];
            Random rand = new Random();
            for (int i = 0; i < 3600; i++)
            {
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);
                sum = dice1 + dice2;
                sumArray[sum - 2]++;
            }
            for(int i=0;i<11;i++)
            {
                Console.WriteLine("Sum " + (i + 2) + ":" + sumArray[i]);                
            }
            Console.ReadLine();
        }
    }
}
