using System;
using System.Collections.Generic;

namespace WheelRailway
{
    class Program
    {
        static void Main(string[] args)
        {
            var railway = new Railway(volume: 5);

            while (true)
            {
                var userinput = Console.ReadLine();
                if (userinput.ToUpper() == "STOP")
                {
                    break;
                }
                railway.Save(userinput);
                continue;
            }

            while (true)
            {
                if (!railway.IsEmpty)
                {
                    Console.WriteLine("\t\t" + railway.Read());
                    continue;
                }
                break;
            }

        }
    }
}
