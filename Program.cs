using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TheCountToOneHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Program.Counter < 100)
            {
                Program.Counter++;
                if (Program.Counter % 3 == 0)
                {
                    if (Program.Counter % 5 == 0)
                    {
                        WriteLine("CameronSean");
                    } else
                    WriteLine("Cameron");
                } else
                if (Program.Counter % 5 == 0)
                {
                    WriteLine("Sean");
                } else
                {
                    WriteLine(Program.Counter);
                }
                
            }
            ReadLine();
        }
        public static int Counter = 0;
    }
}
