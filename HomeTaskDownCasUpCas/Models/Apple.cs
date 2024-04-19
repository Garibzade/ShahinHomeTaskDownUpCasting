using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models
{
    internal class Apple : Fruit
    {
        public Apple(decimal price, string sort, int vitA, int vitB) : base(price, sort)
        {
            _vitaminA = vitA;
            _vitaminB = vitB;
        }
        private int _vitaminA;
        public int VitaminA
        {
            get { return _vitaminA; }
            set { _vitaminA = value; }
        }
        private int _vitaminB;


        public int VitaminB
        {
            get { return _vitaminB; }
            set { _vitaminB = value; }
        }

        public override void Taste()
        {
            Console.WriteLine("Yasil Alma turs qirmizi alma sirin dadir sarida kem sirin");
        }

    }
}
