using System;
using System.Collections.Generic;

namespace WheelRailway_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> wheelie = new Queue<Person>();

            wheelie.Enqueue(new Person { Name = "Hi", Surname = "Hello" });
            wheelie.Enqueue(new Person { Name = "test1", Surname = "tereg2" });
            wheelie.Enqueue(new Person { Name = "ewfwif", Surname = "ewjfijwef" });

            //wheelie.Dequeue();

            while (wheelie.Count > 0)
            {
                var person = wheelie.Dequeue();

                Console.WriteLine($"Name: {person.Name}, Surname: {person.Surname}");
            }
        }
    }
}
