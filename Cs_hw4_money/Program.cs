using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cs_hw4_money
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Домашнее задание № 5 (Money)";
            bool key = true;
            bool res1 = true;
            double res2 = 0.0;
            Money mani1 = new Money();
            Money mani2 = new Money();
            Bitcoin b1 = new Bitcoin();
            Money res = new Money();
            WriteLine(@"Инициализируёте 1-ый объект (Money):");
            Write("Введите рубли: "); mani1.ruble = int.Parse(ReadLine());
            Write("Введите копейки: "); mani1.Kropeck = int.Parse(ReadLine());
            WriteLine(@"Инициализируёте 2-ый объект (Money):");
            Write("Введите рубли: "); mani2.ruble = int.Parse(ReadLine());
            Write("Введите копейки: "); mani2.Kropeck = int.Parse(ReadLine());
            WriteLine($"------------------------------------------------------");
           
            do
            {
                Clear();
                WriteLine($"1-ый объект (Money): {mani1}");
                WriteLine($"2-ый объект (Money): {mani2} ");
               
                WriteLine($"Oбъект (Bitcoid): {b1} ");
                WriteLine($"3-ый объект (Money): {res} ");
                WriteLine($"Oбъект (bool): {res1} ");
                WriteLine($"Oбъект (double): {res2} ");

                WriteLine(@"        Домашнее задание № 5

        1 - Переинициализация объектов класса Money; 
        2 - Перегруженные арифметические операторы  объектов класса Money;
        3 - Перегруженные логические операторы  объектов класса Money;
        4 - Перегруженные операторы переобразования;
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
                            
                            //WriteLine($"1-ый объект: {mani1}");
                            //WriteLine($"2-ый объект: {mani2} ");

                            //Bitcoin b1 = new Bitcoin ();
                            //b1 = (Bitcoin)mani2;
                            //WriteLine($"присвоение Bitcoin: {b1}");
                            //mani1 = (Money)b1;
                            //WriteLine($"присвоение Money: {mani1}");

                        }
                        break;                       
                    case "2":
                        {
                            WriteLine($"Введите следующее значение (+ , - , * , / , %)");
                            Write("\tEnter: ");
                            string str1 = ReadLine();
                            switch (str1)
                            {
                                case "+":
                                    {
                                        res = mani1 + mani2;
                                        WriteLine($"{mani1} + {mani2} = {res}");
                                    }
                                    break;
                                case "-":
                                    {
                                        res = mani1 - mani2;
                                        WriteLine($"{mani1} - {mani2} = {res}");
                                    }
                                    break;
                                case "*":
                                    {
                                        res = mani1 * mani2;
                                        WriteLine($"{mani1} * {mani2} = {res}");
                                    }
                                    break;
                                case "/":
                                    {
                                        res = mani1 / mani2;
                                        WriteLine($"{mani1} / {mani2} = {res}");
                                    }
                                    break;
                                case "%":
                                    {
                                        Write("Введите процент (от 3-го объекта(Money)): "); int pr = int.Parse(ReadLine());
                                        Money procent = res % pr;
                                        WriteLine($"{res} % {pr} = {procent}");
                                    }
                                    break;
                                default:
                                    WriteLine();
                                    WriteLine("\tОшибка ввода");
                                    break;
                            }                           
                        }
                        break;
                    case "3":
                        {
                            WriteLine($"Введите следующее значение (== , != , > , <)");
                            Write("\tEnter: ");
                            string str2 = ReadLine();
                            switch (str2)
                            {
                                case "==":
                                    {
                                        res1 = mani1 == mani2;
                                        WriteLine($"{mani1} == {mani2} = {res1}");
                                    }
                                    break;
                                case "!=":
                                    {
                                        res1 = mani1 != mani2;
                                        WriteLine($"{mani1} != {mani2} = {res1}");
                                    }
                                    break;
                                case ">":
                                    {
                                        res1 = mani1 > mani2;
                                        WriteLine($"{mani1} > {mani2} = {res1}");
                                    }
                                    break;
                                case "<":
                                    {
                                        res1 = mani1 < mani2;
                                        WriteLine($"{mani1} < {mani2} = {res1}");
                                    }
                                    break;
                                default:
                                    WriteLine();
                                    WriteLine("\tОшибка ввода");
                                    break;
                            }
                        }
                        break;
                    case "4":
                        {
                            WriteLine(@"Введите следующее значение:
        1 - От объекта класса Money в значимый тип double;
        2 - От значимого типа double в объект класса Money;
        3 - От объекта класса Money в объект класса Bitcoin
        4 - От объекта класса Bitcoin в объект класса Money");
                            Write("\tEnter: ");
                            string str3 = ReadLine();
                            switch (str3)
                            {
                                case "1":
                                    {
                                        res2 = mani1;
                                        WriteLine($"{res2}");
                                    }
                                    break;
                                case "2":
                                    {
                                        Write($"Переопределите значимый тип double: ");
                                        res2 = Convert.ToDouble(ReadLine());
                                        res =(Money) res2;
                                        WriteLine($"{res}");
                                    }
                                    break;
                                case "3":
                                    {
                                        WriteLine($"Переобразовываем 1 объект класса Money: {mani1}");
                                        b1 =(Bitcoin) mani1;
                                        WriteLine($"{b1}");
                                    }
                                    break;
                                case "4":
                                    {
                                        WriteLine($"Переобразовываем в 3 объект класса Money: {res}");
                                        res = (Money)b1;
                                        WriteLine($"{res}");
                                    }
                                    break;
                                default:
                                    WriteLine();
                                    WriteLine("\tОшибка ввода");
                                    break;
                            }
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
