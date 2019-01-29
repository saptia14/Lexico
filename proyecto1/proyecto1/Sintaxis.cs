using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto1
{
    class Sintaxis : Lexico
    {
        public Sintaxis()
        {
            nextToken();
        }
        
        public void MATCH(string esperado)
        {
            if (esperado == GETContenido()) nextToken();
            else Console.WriteLine("ERROR DE SINTAXIS, Se espera un {0}", esperado);
        }

        public void MATCH(c esperado)
        {
            if (esperado == GETClasificacion()) nextToken();
            else Console.WriteLine("ERROR DE SINTAXIS, Se espera un {0}", STRClasificacion(esperado));
        }
    }
}