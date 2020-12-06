using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AoC2020Day6
{
    class Helpers
    {
        public static String readToBuffer(int day)
        {
            StreamReader sr = new StreamReader(@"C:\Users\thoma\Documents\AoC\input\2020\day" + day + @".txt");
            string input = sr.ReadToEnd();
            sr.Close();
            return input;
        }

        public static List<int> readToIntList(int day, char delim = '\n')
        {
            String strIn = readToBuffer(day);
            String[] parts = strIn.Trim().Split(delim);

            List<int> lout = new List<int>();
            foreach (string s in parts)
                lout.Add(int.Parse(s));
            return lout;

        }

        public static List<String> readToStringList(int day, char delim = '\n')
        {
            String strIn = readToBuffer(day);
            String[] parts = strIn.Trim().Split(delim);

            return parts.ToList<String>();


        }

        public static List<string> readAsBlankSeparatedBlocks(int day, char delim = '\n'  )
        {
            String strIn = readToBuffer(day);
            String[] parts = strIn.Trim().Split(delim);

            List<string> blocks = new List<string>();
            string line = "";
            for(int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Trim() == "")
                {
                    blocks.Add(String.Copy(line));
                    line = "";

                }
                else
                {
                    line += parts[i];
                }
            }
            blocks.Add(line);

            return blocks;
            

        }





    }
}
