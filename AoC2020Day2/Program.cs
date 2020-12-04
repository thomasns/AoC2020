using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lin = Helpers.readToStringList(2);


            int partOneCorrect = 0;
            int partTwoCorrect = 0;
            for (int i = 0; i < lin.Count; i++)
            {
                //Parse line.
                // n-n split space 3

                string[] parts = lin[i].Split(' ');

                //1-1 counts
                int min = int.Parse(parts[0].Split('-')[0]); ;
                int max = int.Parse(parts[0].Split('-')[1]); ;

                // b: char
                char c = parts[1][0];
                int dings = 0;
                for(int j = 0; j < parts[2].Length; j++)
                {
                    if (parts[2][j] == c)
                        dings++;
                }
                if (dings <= max && dings >= min)
                    partOneCorrect++;



                if (parts[2][min - 1] == c && parts[2][max - 1] == c)
                    continue;
                if (parts[2][min - 1] == c || parts[2][max - 1] == c)
                {
                    partTwoCorrect++;
                }


            }
            Console.WriteLine("Part 1 Correct: " + partOneCorrect);
            Console.WriteLine("Part 2 Correct: " + partTwoCorrect);
            Console.ReadLine();




        }
    }
}
