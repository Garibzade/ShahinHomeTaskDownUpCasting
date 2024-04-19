using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models2
{
    internal class Grass:Food
    {
        public Grass(string name, int kalori):base(kalori)
        {
                _name= name;
        }
        private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

	}
}
