using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] output = new int[10];
            output[0] = rand.Next(5,26);
            int Minimum = output[0];
            int Maximum = output[0];
            int Total = output[0];
            for(int i=1; i<output.Length; i++)
            {
                output[i] = rand.Next(5, 26);
                if(Minimum>output[i])
                {
                    Minimum = output[i];
                }
                if(Maximum<output[i])
                {
                    Maximum = output[i];
                }
                Total += output[i];
            }
            Console.WriteLine($"Minimum: {Minimum} Maximum: {Maximum} Total: {Total}");
            return output;
        }

        public static string CoinFlip()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int HeadsorTails = rand.Next(1,3);
            string Result;
            if(HeadsorTails == 1)
            {
                Result = "Heads";
            }
            else if(HeadsorTails == 2)
            {
                Result = "Tails";
            }
            else
            {
                Result = "That wasn't supposed to happen";
            }
            return Result;
        }
        public static double TossMultipleCoins(int num)
        {
            Random rand = new Random();
            double Heads = 0;
            double Tails = 0;
            for(int i=1; i<=num; i++)
            {
                int HeadsorTails = rand.Next(1,3);
                if(HeadsorTails == 1)
                {
                    Heads++;
                }
                else if(HeadsorTails == 2)
                {
                    Tails++;
                }
                else
                {
                    Console.WriteLine("That wasn't supposed to happen");
                }
            }
            double output = Heads/Tails;
            return output;
        }
        public static List<string> Names()
        {
            Random random= new Random();
            List<string> people = new List<string>();
            List<string> shuffled = new List<string>();
            List<string> output = new List<string>();
            people.Add("Todd");
            people.Add("Tiffany");
            people.Add("Charlie");
            people.Add("Geneva");
            people.Add("Sydney");
            while(people.Count>0)
            {
                int CurrentPerson = random.Next(0, people.Count);
                shuffled.Add(people[CurrentPerson]);
                people.Remove(people[CurrentPerson]);
            }
            for(int i=0; i<shuffled.Count; i++)
            {
                Console.WriteLine(shuffled[i]);
                if(shuffled[i].Length>5)
                {
                    output.Add(shuffled[i]);
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine(CoinFlip());
            Console.WriteLine(TossMultipleCoins(25));
            Console.WriteLine(Names());
        }
    }
}
