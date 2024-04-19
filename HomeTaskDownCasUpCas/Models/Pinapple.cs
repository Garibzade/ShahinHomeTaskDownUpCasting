using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models
{
    internal class Pinapple : Fruit
    {

        private int _vitaminE;
        public int VitaminE
        {
            get { return _vitaminE; }
            set { _vitaminE = value; }
        }
        private int _vitaminD;

        public Pinapple(decimal price, string sort, int vitE, int vitD) : base(price, sort)
        {
            _vitaminE = vitE;
            _vitaminD = vitD;
        }

        public int VitaminD
        {
            get { return _vitaminD; }
            set { _vitaminD = value; }
        }

        public override void Taste()
        {
            Console.WriteLine("Tursmeze dadi var biraz ama bele daddidi");
        }
    }
}
