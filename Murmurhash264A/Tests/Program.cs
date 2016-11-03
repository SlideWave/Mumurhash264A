using System;
using System.Text;
using Murmurhash264A;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a";
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(s.PadRight(18) + Murmur2.Hash(Encoding.ASCII.GetBytes(s), 0));
                s += "a";
            }
        }
    }
}
