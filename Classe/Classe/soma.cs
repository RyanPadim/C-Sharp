﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    internal class soma
    {
        private int n1;
        private int n2;
        public void setN1(int n1)
        {
            this.n1 = n1;
        }
        public void setN2(int n2)
        {
            this.n2 = n2; 
        }
        public int getN1()
        {
            return this.n1;
        }
        public int getN2()
        {
            return this.n2;
        }
        public int somar()
        {
            return (this.n1 + this.n2);
        }
    }
}
