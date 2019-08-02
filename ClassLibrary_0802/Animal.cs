using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_0802
{
    public abstract class Animal
    {








        public String Name;
        public virtual void Run()
        {
            Console.WriteLine("I can not run");
        }

        public abstract void Wight();
    }
}
