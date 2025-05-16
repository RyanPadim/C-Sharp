using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    internal abstract class Automovel
    {
        private int _ano;
        private string _cor;

        public int getAno()
        {
            return _ano;
        }

        public string getCor()
        {
            return _cor;
        }

        public void setAno(int ano)
        {
            _ano = ano;
        }
        public void setCor(string cor)
        {
            _cor = cor;
        }
        public Automovel(int ano, string cor)
        {
            setAno(ano);
            setCor(cor);
        }

        public void andar()
        {
            Console.WriteLine("Carro andando!");
        }

        public abstract void frear();
    }
}
