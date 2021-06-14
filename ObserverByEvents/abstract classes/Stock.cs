using ObserverByEvents.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByEvents.abstract_classes
{
    abstract class Stock
    {

        protected double _Price;

        protected String _Symbol;

        public event EventHandler<ChangeEventArgs> ChangePrice;

        protected Stock(String Symbol, double Price)
        {
            _Price = Price;
            _Symbol = Symbol;
        }

        protected virtual void OnChange(ChangeEventArgs e)
        {
            if (ChangePrice != null)
            {
                ChangePrice.Invoke(this, e);
            }
        }


        public void Attach(Investor newInverstor)
        {
            ChangePrice += newInverstor.Update;
        }


        public void DeAttach(Investor removedInvestor)
        {
            ChangePrice -= removedInvestor.Update;
        }

        public double price
        {
            get { return _Price; }
            set
            {
                if (_Price != value)
                {
                    _Price = value;

                    OnChange(new ChangeEventArgs { price = _Price, symbol = _Symbol });

                    Console.WriteLine("");
                
                }
            }
        }
    }

}

