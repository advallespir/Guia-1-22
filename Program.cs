using System;

namespace Guia_1_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var DiaYFecha = DateTime.Now;
            var SoloDia = DiaYFecha.ToShortDateString(); ;
            Console.WriteLine($"{SoloDia}");
            Console.ReadKey();
        }
    }
}
