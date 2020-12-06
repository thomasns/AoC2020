using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> blocks = Helpers.readAsBlankSeparatedBlocks(6);

            int groupCount = 0;
            int total = 0;
            for (int i = 0; i < blocks.Count; i++)
            {
                groupCount = 0;
                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (blocks[i].Contains(c))
                        groupCount++;
                }
                total += groupCount;
            }
            Console.WriteLine("Part 1:" + total);

            total = 0;
            for (int i = 0; i < blocks.Count; i++)
            {
                groupCount = 0;
                string[] answers = blocks[i].Trim().Split('\r');
                for (char c = 'a'; c <= 'z'; c++)
                {
                    bool all = true;
                    for (int j = 0; j < answers.Length; j++)
                    {
                        if (!answers[j].Contains(c))
                        {
                            all = false;
                            break;
                        }
                    }
                    if (all)
                        groupCount++;
                }
                total += groupCount;
            }
            Console.WriteLine("Part 2: " + total);
            Console.ReadLine();
        }
    }
}
