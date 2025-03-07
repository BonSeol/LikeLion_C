using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_25_02_26_3
{
    class Program
    {
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void Main(string[] args)
        {
            int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");
        }
    }
}
