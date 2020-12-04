using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Helpers.readToIntList(1);
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[i] + list[j] == 2020)
                    {
                        Console.WriteLine(i + " + " + j + " == 2020" + "i * j = " + list[i] * list[j]); 
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    for (int k = 2; k < list.Count; k++)
                    {
                        if (list[i] + list[j] + list[k] == 2020)
                        {
                            Console.WriteLine(i + " + " + j +  " + " + k + " == 2020" + "i * j * k = " + list[i] * list[j] * list[k]);
                        }
                    }
                }
            }


            Console.ReadLine();

        }
    }
}
