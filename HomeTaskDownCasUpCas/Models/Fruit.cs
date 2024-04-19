using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.Models
{
    abstract class Fruit
    {
        protected Fruit(decimal price, string sort)
        {
            _price = price;
            _sort = sort;
        }
        private decimal _price;
        public decimal MyProperty
        {
            get { return _price; }
            set { _price = value; }
        }
        private string _sort;
        public string Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
        public abstract void Taste();
    }
}
