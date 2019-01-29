
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace proyecto1
{
    class Lexico : token
    {
        public StreamReader archivo;
        public StreamWriter log;

        public Lexico()
        {
            archivo = new StreamReader(@"C:\opt\StreamReader\prueba.txt");
            log = new StreamWriter(@"C:\opt\StreamReader\prueba.log");
            log.WriteLine("Bitacora de Compilacion");
        }
        
        public int automata(int renglon, int columna)
        {
            int estado = 0;
            const int F = -1;
            const int E = -2;
            int[,] TRAND =
            {//  WS   L   D   .   E   +  -  lam
                { 0 , 1 , 2 , 8 , 1 , 9 ,9 , 8 },
                { F , 1 , 1 , F , F , F ,F , F },
                { F , F , 2 , 3 , 5 , F ,F , F },
                { E , E , 4 , E , E , E ,E , E },
                { F , F , 4 , F , 5 , F ,F , F },
                { E , E , 7 , E , E , 6 ,6 , E },
                { E , E , 7 , E , E , E ,E , E },
                { F , F , 7 , F , F , F ,F , F },
                { F , F , F , F , F , F ,F , F },
                { F , F , F , F , F , F ,F , F }
            };
            switch (TRAND[renglon, columna])
            {
                case 1: SETClasificacion(c.Identificador);
                    break;
                case 2: SETClasificacion(c.Numero);
                    break;
                case 8: SETClasificacion(c.Caracter);
                    break;
                case 9:
                    SETClasificacion(c.OperadorTermino);
                    break;

            }
            return TRAND[renglon, columna];
        }

        private int columna(char signo)
        {
            if (char.IsWhiteSpace(signo)) return 0;
            else if (char.ToUpper(signo) == 'E') return 4;
            else if (char.IsLetter(signo)) return 1;
            else if (char.IsDigit(signo)) return 2;
            else if (signo == '.') return 3;
            else if (signo == '+') return 5;
            else if (signo == '-') return 6;
            else return 7;
        }

        public void nextToken()
        {
            char c;
            int estado = 0;
            string buffer = "";

            while (estado >= 0)
            {
                c = (char)archivo.Peek();
                estado = automata(estado,columna(c));
                if (estado >= 0) //Si no es fin de archivo o error.
                {
                    archivo.Read();
                    if(estado > 0) buffer += c; //Concatena caracteres validos "No espacios".
                }
                //Console.WriteLine("almacenado: {0}",buffer);
            }
            SETContenido(buffer);
        }
    }
}
