using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_0802
{
    public static class SaticClass
    {
        public static void AA()
        {
            Console.WriteLine("this is a method");
        }

        public static string Append(this string s)
        {
            return s+"dhsfh";
        }
    }
}
