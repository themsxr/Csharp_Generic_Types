using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
            {
                new Worker {Name = "Adam", Surname = "Badam"},
                new Worker {Name = "Red", Surname = "Yellow"},
                new Worker {Name = "Hi", Surname = "Hello"},
            };

            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} {worker.Surname}");
            }

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"------> {workers[i].Name} {workers[i].Surname}");
            }


            Array.Resize(ref workers, 10);
            workers[9] = new Worker { Name = "Test", Surname = "Test2" };

            Console.WriteLine($">>>>>>> {workers[9].Name} {workers[9].Surname}");
        }
    }
}
