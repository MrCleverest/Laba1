using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Laba1
{
    internal class General : Copybook
    {
        private bool isCover; // вказує, чи є обкладинка
        private string material = "";

        public General(string name, int k, bool isCover) : base(name, k)
        {
            this.isCover = isCover;
        }

        public string Material { 
            get { return material; } 
            set { material = value; }
        }

        // Перевизначений метод для розрахунку вартості зошита з урахуванням наявності обкладинки
        public override double Cost()
        {
            double price = base.Cost();

            // Якщо є обкладинка, додаємо надбавку
            if (isCover)
            {
                price += 50;
            }

            return price;
        }
    }
}
