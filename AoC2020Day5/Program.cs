using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "BFFFBBFRRR";
            List<string> lin = Helpers.readToStringList(5);
            int maxSeat = 0;

            foreach (string line in lin)
            {
                if(checksum(line) > maxSeat)
                    maxSeat = checksum(line);
            }
            Console.WriteLine(maxSeat);


            bool[,] seats = new bool[128, 8];
            List<int> takenSeats = new List<int>();
            foreach (string line in lin)
            {
                plugArray(seats,line);
                takenSeats.Add(checksum(line));
            }

            for(int i = 0; i < 128; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (!seats[i, j])
                    {
                        int value = i * 8 + j;
                        if(takenSeats.Contains(value-1) && takenSeats.Contains(value+1))
                        {
                            Console.WriteLine(value);
                        }

                    }
                }
            }
            Console.ReadLine();
        }


        static void plugArray(bool[,] seats, string lin)
        {
            int row = findRow(lin.Substring(0, 7));
            int column = findRow(lin.Substring(7, 3), 'R');

            seats[row, column] = true;

            
        }
        
        static int checksum(string lin)
        {
            int row = findRow(lin.Substring(0, 7));
            int column = findRow(lin.Substring(7, 3), 'R');

            return row * 8 + column;
        }
    
        static int findRow(string sin, char onBit = 'B')
        {
            int value = 0;

            for(int i = 0; i < sin.Length;  i++)
            {
                if (sin[i] == onBit) 
                    value += 1;
                value = value << 1;
            }
            value = value >> 1;

            return value;
        }
    }
}
