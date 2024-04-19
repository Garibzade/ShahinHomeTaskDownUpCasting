using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models2
{
    abstract class Animal
    {
        protected Animal(string breed)
        {
            _breed = breed;
        }
        private string _breed;

		public String Breed
		{
			get { return _breed; }
			set { _breed = value; }
		}
		public abstract void MakeSound();
		public abstract void EatFood(Food food);
			
	}
}
