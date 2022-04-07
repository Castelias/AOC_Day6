using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AOC_Day6
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\piotr\source\repos\AOC_Day6\AOC_Day6\inputFile.txt";
            List<string> inputList = File.ReadAllLines(path).ToList();

            List<int> startingFishList = new List<int>();

            List<Fish> fishList = new List<Fish>();
            Regex regx = new Regex(@"[0-9]");
            MatchCollection matches = regx.Matches(inputList[0]);

            foreach (Match match in matches)
            {
                startingFishList.Add(Convert.ToInt32(match.Value));
                fishList.Add(new Fish());
            }

            for (int i = 0; i < startingFishList.Count; i++)
            {
                fishList[i].timeToReproduce = startingFishList[i];
                fishList[i].isNew = false;
            }

            for (int i = 0; i < 256; i++)
            {                
                for (int j = 0; j < fishList.Count; j++)
                {
                    if(fishList[j].TryToReproduce())
                    {
                        fishList.Add(new Fish());
                    }
                    if(!fishList[j].isNew)
                    {
                        fishList[j].DecreaseTimeToReproduce();
                    }                     
                    fishList[j].isNew = false;                                      
                   // Console.Write(fishList[j].timeToReproduce + ", ");
                }
                //  Console.WriteLine(" ");

            }
            Console.WriteLine(fishList.Count + " <- Liczba rybek");
        }
    }
}
