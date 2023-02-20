using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cs_hw4_money
{
    class Money
    {
        public int ruble { get; set; } = 0;

        private int kopeck;
        public int Kropeck
        {
            get { return kopeck; }
            set
            {
                while (value >= 100)
                {
                    ++ruble;
                    value -= 100;
                }
                kopeck = value;
            }
        }

        public override bool Equals(object obj) => this.ToString() == obj.ToString();

        public override int GetHashCode() => this.ToString().GetHashCode();

        public static Money operator +(Money m1, Money m2) => new Money { Kropeck = (m1.kopeck + m2.kopeck) + ((m1.ruble + m2.ruble) * 100) };

        public static Money operator -(Money m1, Money m2) => new Money { Kropeck = (m1.kopeck - m2.kopeck) + ((m1.ruble - m2.ruble) * 100) };

        public static Money operator *(Money m1, Money m2) => new Money { Kropeck = (m1.kopeck * m2.kopeck) + ((m1.ruble * m2.ruble) * 100) };
        public static Money operator %(Money m1, double pr)
        {
            Money res = new Money();
            double result = (m1.ruble * 100) + m1.kopeck;
            result *= (pr / 100);
            res.Kropeck = Convert.ToInt32(result);
            return res;
        }
        public static Money operator /(Money m1, Money m2)
        {
            double result = ((m1.ruble * 100) + m1.kopeck) / ((m2.ruble * 100) + m2.kopeck);
            if (result == 0) return null;
            return new Money { Kropeck = Convert.ToInt32(result) };
        }
        public static bool operator >(Money m1, Money m2) => (m1.ruble+m1.kopeck) > (m2.ruble + m2.kopeck);
        public static bool operator <(Money m1, Money m2) => (m1.ruble + m1.kopeck) < (m2.ruble + m2.kopeck);
        public static bool operator ==(Money m1, Money m2) => (m1.ruble + m1.kopeck) == (m2.ruble + m2.kopeck);
        public static bool operator !=(Money m1, Money m2) => (m1.ruble + m1.kopeck) != (m2.ruble + m2.kopeck);

        public static implicit operator double(Money m1)
        {
            string str = Convert.ToString($"{m1.ruble},{m1.kopeck}");
            double res = Convert.ToDouble(str);
            return res;
        }
        public static explicit operator Money(double m1)
        {
            string str = Convert.ToString(Math.Round(m1, 2));
            Money res = new Money();
            char s = ',';
            string[] num = str.Split(s);
            res.ruble = int.Parse(num[0]);
            res.Kropeck = int.Parse(num[1]);
            return res;
        }
        public static explicit operator Money(Bitcoin b1)
        {
            Money m1 = new Money();
            double d1 = b1.Quantity * b1.Price;
            m1 = (Money)d1;
            WriteLine($"{b1.Quantity} бикоинов по {b1.Price} рублей, будет {m1}");
            return m1;
        }

        public override string ToString() => $"{ruble} рублей {kopeck} копеек";
    }
}
