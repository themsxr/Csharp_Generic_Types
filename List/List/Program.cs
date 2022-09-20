using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker {Name = "Adam", Surname = "Badam"},
                new Worker {Name = "Red", Surname = "Yellow"},
                new Worker {Name = "Hi", Surname = "Hello"},
            };

            workers.Add(new Worker { Name = "John", Surname = "Adams" });

            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} {worker.Surname}");
            }

            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine($"------> {workers[i].Name} {workers[i].Surname}");
            }

            Console.WriteLine("================================");

            var nlist = new List<int>();
            var size = -1;

            while (true)
            {
                if (nlist.Capacity != size)
                {
                    size = nlist.Capacity;
                    Console.WriteLine(size);
                }

                try
                {
                    nlist.Add(1);
                }
                catch (OutOfMemoryException)
                {
                    throw new ArgumentException("No space!");
                    
                }
            }
        }
    }
}
