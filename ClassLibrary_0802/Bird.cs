using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_0802
{
    public class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
        public override void Run()
        {
            Console.WriteLine("I can not run");
        }
        public override void Wight()
        {
            Console.WriteLine("1kg");
        }

        public Bird()
        {
            base.Name = "Bird";
            Console.WriteLine(base.Name);
        }
    }
}
