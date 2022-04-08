using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine("Tossing A Coin!");
            TossCoin();
            TossMultipleCoins(50);
            Names();
        }
        public static void RandomArray()
        {
            List<int> randArray = new List<int>();

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                randArray.Add(rand.Next(5, 25));
            }
            int[] numArray = randArray.ToArray();

            foreach (int value in randArray)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Minimum number = " + numArray.Min());
            Console.WriteLine("Maximum number = " + numArray.Max());
            Console.WriteLine("Sum of all the numbers = " + numArray.Sum());
        }

        public static void TossCoin()
        {
            List<string> randlist = new List<string>();
            randlist.Add("Heads");
            randlist.Add("Tails");

            Random rand = new Random();
            int idx = rand.Next(randlist.Count);
            Console.WriteLine(randlist[idx]);
        }

        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double tails = 0;
            double ratio = 0;

            Random rand = new Random();
            for (int i = 0; i < num; i++)
            {
                int coin = rand.Next(5, 5000);
                if (coin % 2 == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            ratio = (heads / tails) * 100;
            ratio = Math.Floor(ratio / 2);
            Console.WriteLine($"We tossed the coin {num} times. The ratio from heads to tails was {ratio}%.");
            Console.WriteLine($"It was heads {heads} times. It was tails {tails} times.");

            return ratio;
        }

        public static void Names()
        {
            List<string> nameList = new List<string>();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");

            Random rand = new Random();
            for (var idx = 0; idx < nameList.Count; idx++)
            {
                if(nameList[idx].Length > 5)
                {
                Console.WriteLine(nameList[idx]);
                }
            }
        }
    }
}
