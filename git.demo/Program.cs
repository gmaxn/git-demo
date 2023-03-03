using git.demo.A;
using git.demo.B;
using System;

namespace git.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ServicioA();
            var b = new ServicioB();

            a.Print();
            b.Print();
        }
    }
}
