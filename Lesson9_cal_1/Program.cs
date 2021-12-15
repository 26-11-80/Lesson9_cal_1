using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_cal_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");
            try

            {

                Console.WriteLine("Введите первое число: x=");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: y=");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оператора");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умножение");
                Console.WriteLine("4 - деление");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("результат:");
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine(a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(a * b);
                            break;
                        }
                    case 4:
                        {
                            if (b != 0)
                            {
                                double x = Convert.ToDouble(a);
                                double y = Convert.ToDouble(b);
                                Console.WriteLine(x / y);
                            }
                            else
                            {
                                Console.WriteLine("ошибка! на ноль делить нельзя");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("ошибка! несуществующий оператор");
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("входная строка имела неверный формат");
            }
            Console.ReadKey();
        }
    }
}

                            


                            
                        
                        

                        

                       
                    
            
        
    

