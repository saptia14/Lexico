using System;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sintaxis t = new Sintaxis();
            /*
            while (!t.archivo.EndOfStream)
            {
                t.nextToken();
                Console.WriteLine(t.GETContenido() + " = " + t.STRClasificacion());
                //Console.WriteLine("Almacenado: {0}", t.GETContenido());
            }
            */
            
            t.MATCH("x26");
            t.MATCH("=");
            t.MATCH("3.5e-8");
            Console.ReadKey();
        }
    }
}
