using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos_Ex01
{
    public class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double Calculo(double cotacao, double valor)
        {
            return cotacao * valor * (Iof / 100.0);
        }

    }
}
