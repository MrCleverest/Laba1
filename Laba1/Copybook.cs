using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class Copybook
    {
        protected string name;
        protected int k; 

        public Copybook(string name, int k)
        {
            this.name = name;
            this.k = k;
        }

        // Метод для розрахунку вартості зошита
        public virtual double Cost()
        {
            return 15 * k;
        }
    }
}
