using System;
using System.Collections.Generic;

namespace WheelRailway
{
    class Program
    {
        static void Main(string[] args)
        {
            //var railway = new Railway<double>(volume: 5);

            //while (true)
            //{
            //    var userinput = Console.ReadLine();
            //    if (userinput.ToUpper() == "STOP")
            //    {
            //        break;
            //    }
            //    railway.Save(double.Parse(userinput));
            //    continue;
            //}

            //while (true)
            //{
            //    if (!railway.IsEmpty)
            //    {
            //        Console.WriteLine("\t\t" + railway.Read());
            //        continue;
            //    }
            //    break;
            //}

            var PersonRailway = new Railway<Person>(volume: 8);
            PersonRailway.Save(new Person { Name = "Michael", Surname = "Sunny" });
            PersonRailway.Save(new Person { Name = "Adams", Surname = "Beach" });
            PersonRailway.Save(new Person { Name = "Ben", Surname = "Yellow" });
            ReadingMethod(PersonRailway);

        }

        private static void ReadingMethod(Railway<Person> PersonRailway)
        {
            while (!PersonRailway.IsEmpty)
            {
                var result = PersonRailway.Read().Name;
                Console.WriteLine(result);
            }
        }
    }
}
