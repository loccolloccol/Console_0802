using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_0802
{
    public class Cat : Animal
    {
        public override void Run()
        {
            Console.WriteLine("I can run");
        }
        public override void Wight()
        {
            Console.WriteLine("5kg");
        }
        public void wall()
        {
            Console.WriteLine("Climbing the wall");
        }
        public Cat()
        {
            base.Name = "Cat";
            Console.WriteLine(base.Name);
        }
    }
}
