using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models
{
    internal class Orange : Fruit
    {
        private int _vitaminC;

        public Orange(decimal price, string sort, int vitC) : base(price, sort)
        {
            _vitaminC = vitC;
        }
        public int VitaminC
        {
            get { return _vitaminC; }
            set { _vitaminC = value; }
        }
        public override void Taste()
        {
            Console.WriteLine("Sirindi prosda biraz turs teherdi");
        }
    }
}
