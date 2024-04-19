using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models2
{
    internal class Lion : Animal
    {
        
        private bool _isPrideLeader;

        public Lion(string breed,bool Leader) : base(breed)
        {

            _isPrideLeader = Leader;
        }

        public bool IsPrideLeader
        {
            get { return _isPrideLeader; }
            set { _isPrideLeader = value; }
        }

        public override void EatFood(Food food)
        {
            if(food is Meat)
            {Console.WriteLine("Duzgun qida");
            } 
            else{Console.WriteLine("Yalnish qida"); }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Sir Hemise sirdi mem qerdesim");
        }
    }
}
