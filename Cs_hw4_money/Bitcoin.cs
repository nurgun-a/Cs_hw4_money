using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cs_hw4_money
{
    class Bitcoin
    {
        public double Quantity { get; set; }
        public double Price { get; set; } = 1847813.26;
        public static implicit operator Bitcoin(Money m1)
        {            
            Bitcoin b1 = new Bitcoin();
            b1.Quantity = (double) m1 / b1.Price;            
            return b1;
        }
    public override string ToString() => $"Количество: {Quantity}; цена за еденицу: {Price} руб.";

    }
}
