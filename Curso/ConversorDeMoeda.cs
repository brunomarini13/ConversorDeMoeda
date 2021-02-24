using System;


namespace Curso
{
    class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double Dolares;
        public static double Conversao()
        {
            return Cotacao * Dolares + 0.06 * Cotacao * Dolares;
        }

    }
}
