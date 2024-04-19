using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models2
{
    internal class Cow : Animal
    {
        public Cow(string breed) : base(breed)
        {

        }

        public override void EatFood(Food food)
        {
            if(food is Grass)
            {
                Console.WriteLine("Guzgun qida"); 
            }
            else { Console.WriteLine("Yalnish qida"); }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Ineklere azadliqqqq");
        }
        public void ProducedMilk() 
        {
            Console.WriteLine("Milk Produced");
        }
    }
}
