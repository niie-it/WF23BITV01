using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
        protected void Run() => Console.WriteLine("Running...");
        private void DoSomething() => Console.WriteLine("Doing...");
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Run();
            // DoSomething();
            Console.WriteLine("Dog is barking.");
        }
    }
}
