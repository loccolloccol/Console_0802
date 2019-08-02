using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_0802
{
    public class Dog : Animal
    {
        public override void Run()
        {
            Console.WriteLine("I can run");
        }
        public override void Wight()
        {
            Console.WriteLine("12kg");
        }
        public Dog()
        {
            base.Name="Dog";
            Console.WriteLine(base.Name);
        }
    }
}
