using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models2
{
    internal class Meat : Food
    {
        public Meat(int kalori,string type) : base(kalori)
        {
            _type = type;
        }
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
