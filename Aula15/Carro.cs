using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    internal class Carro : Automovel
    {

        public string _numRenavam;

        public string getNumRenavam()
        {
            return _numRenavam;
        }

        public void setNumRenavam(string numRenavam)
        {
            _numRenavam = numRenavam;
        }


        public Carro(string numRenavam, int ano, string cor) : base(ano, cor)
        {
            setNumRenavam(numRenavam);
        }
        public override void frear()
        {
            Console.WriteLine("Carro freando!");
        }
    }
}
