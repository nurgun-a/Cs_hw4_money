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
                while (value>=100)
                {
                    ++ruble;
                    value -= 100;                    
                }
                kopeck = value;
            }
        }
        static public Money operator + (Money m1,Money m2)
        {
            Money sum=new Money();
            sum.ruble = m1.ruble + m2.ruble;
            sum.Kropeck=m1.kopeck + m2.kopeck;
            return sum;
        }

        static public Money operator % (Money m1, double pr)
        {
            Money res = new Money();
            double result = (m1.ruble * 100) + m1.kopeck;
            result *= (pr/ 100);
            res.Kropeck=Convert.ToInt32(result);
            return res;
        }
        public override string ToString()
        {
            return $"{ruble} рублей {kopeck} копеек";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Домашнее задание № 4 (Money)";
            bool key = true;
            Money mani1 = new Money();
            Money mani2 = new Money();
            Money sum = new Money();

            do
            {
                Clear();
                WriteLine(@"        Домашнее задание № 4
        Создать класс Money со свойствами РУБЛИ и КОПЕЙКИ.
        Реализовать функционал:

        1 - Выполнить начальную инициализацию этих свойств, 
        2 - Cоздать метод сложения двух объектов этого класса,
        3 - Cоздать метод нахождения процента от объекта ( например, для расчета скидки или налога).
        0 - Выход");

                WriteLine();
                Write("\tEnter: ");
                string str = ReadLine();
                switch (str)
                {
                    case "1":
                        {
                            WriteLine(@"Инициализируёте 1-ый объект:");
                            Write("Введите рубли: "); mani1.ruble = int.Parse(ReadLine());
                            Write("Введите копейки: "); mani1.Kropeck = int.Parse(ReadLine());
                            WriteLine(@"Инициализируёте 2-ый объект:");
                            Write("Введите рубли: "); mani2.ruble = int.Parse(ReadLine());
                            Write("Введите копейки: "); mani2.Kropeck = int.Parse(ReadLine());
                            WriteLine($"------------------------------------------------------");
                            WriteLine($"1-ый объект: {mani1}");
                            WriteLine($"2-ый объект: {mani2} ");
                        }
                        break;
                       
                    case "2":
                        {
                            sum = mani1 + mani2;
                            WriteLine($"{mani1} + {mani2} = {sum}");
                        }
                        break;
                    case "3":
                        {
                            Write("Введите процент: "); int pr = int.Parse(ReadLine());
                            Money procent = sum % pr;
                            WriteLine($"{sum} % {pr} = {procent}");
                        }
                        break;
                    case "0":
                        {
                            key = false;
                        }
                        break;
                    default:
                        WriteLine();
                        WriteLine("\tОшибка ввода");
                        break;
                }
                if (str != "0") Write("\tНажмите \"Enter\" чтобы продолжить ... ");
                if (str != "0") ReadLine();

            } while (key);
        }
    }
}
