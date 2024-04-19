using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models2
{
    abstract class Food
    {

        protected Food(int kalori)
        {
            _kalori = kalori;
        }
        private int _kalori;
		public int _Kalori 
		{
			get { return _kalori; }
			set { _kalori = value; }
		}
        public static void MakeSound() 
        {
        
        }
	}
}
