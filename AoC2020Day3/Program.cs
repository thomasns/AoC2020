using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lin = Helpers.readToStringList(3);

            int slopeDown = 1;
            int slopeRight = 3;

            int treeCount = sledRun(lin, slopeRight, slopeDown);
            Console.WriteLine(treeCount);



            long product = sledRun(lin, 1, 1);
            product *= sledRun(lin, 3, 1);
            product *= sledRun(lin, 5, 1);
            product *= sledRun(lin, 7, 1);
            product *= sledRun(lin, 1, 2);
            Console.WriteLine(product);

            Console.ReadLine();

        }




        private static int sledRun(List<string> lin, int slopeRight , int slopeDown)
        {
            int x = 0;

            int treeCount = 0;
            for (int y = 0; y < lin.Count; y += slopeDown)
            {
                lin[y] = lin[y].Trim();
                if (lin[y][x % lin[y].Length] == '#')
                    treeCount++;

                x += slopeRight;
            }
            return treeCount;
        }
    }
}
