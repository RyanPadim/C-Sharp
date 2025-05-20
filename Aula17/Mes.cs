using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17
{
    internal enum Mes
    {
        Janeiro = 1,
        Fevereiro = 2,
        Março = 3,
        Abril = 4,
        Maio = 5,
        Junho = 6,
        Julho = 7,
        Agosto = 8,
        Setembro = 9,
        Outubro = 10,
        Novembro = 11,
        Dezembro = 12
    }
    class Program
    {
        static void main()
        {
            Mes mes1 = Mes.Janeiro;
            int i1 = (int)Mes.Janeiro;

            System.Console.WriteLine(mes1);
            System.Console.WriteLine(i1);
            Console.ReadKey();

            Mes mes2 = Mes.Julho;
            int i2 = (int)Mes.Julho;

            System.Console.WriteLine(mes2);
            System.Console.WriteLine(i2);
            Console.ReadKey();
        }
    }
}
