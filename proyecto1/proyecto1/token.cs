using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto1
{
    class token
    {
        public enum c
        {
            Identificador,
            Numero,
            Caracter,
            OperadorTermino,
        }; 
        public c clasificacion;
        private string contenido = "";
        
        //int const Identificador = 0, Numero = 1, Caracter = 2;
        public void SETContenido(string c)
        {
            contenido = c;
        }
        public void SETClasificacion(c clasificacion)
        {
            this.clasificacion = clasificacion;
        }
        public string GETContenido()
        {
            return contenido;
        }
        public c GETClasificacion()
        {
            return clasificacion;
        }
        public string STRClasificacion()
        {
            switch (clasificacion)
            {
                case c.Identificador: return "Identificador";
                case c.Numero: return "Numero";
                case c.Caracter: return "Caracter";
                case c.OperadorTermino: return "Operador de termino";
                //case : return "Identificador";
                //case : return "Identificador";
                //case : return "Identificador";
                //case : return "Identificador";
                //case : return "Identificador";
                default: return "Sin clasificacion";
            }
        }
        public string STRClasificacion(c clasificacion)
        {
            switch (clasificacion)
            {
                case c.Identificador: return "Identificador";
                case c.Numero: return "Numero";
                case c.Caracter: return "Caracter";
                case c.OperadorTermino: return "Operador de termino";
                //case 4: return "Identificador";
                //case 5: return "Identificador";
                //case 6: return "Identificador";
                //case 7: return "Identificador";
                //case 8: return "Identificador";
                default: return "Sin clasificacion";
            }
        }
    }
}
