using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        // 1
     
        static void Main(string[] args)
        {            

            Console.Write("Введите ваш любимый цвет: ");
            string color = Console.ReadLine();

            switch (color)
            {
                case "Black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет: [Black]");
                    Console.ResetColor();
                    break;

                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ваш любимый цвет: [Blue]");
                    Console.ResetColor();
                    break;

                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ваш любимый цвет: [Red]");
                    Console.ResetColor();
                    break;

                case "Cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ваш любимый цвет: [Cyan]");
                    Console.ResetColor();
                    break;

                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваш любимый цвет: [Green]");
                    Console.ResetColor();
                    break;

                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ваш любимый цвет: [Yellow]");
                    Console.ResetColor();
                    break;

                case "Gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Ваш любимый цвет: [Gray]");
                    Console.ResetColor();
                    break;

                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Ваш любимый цвет: [Magenta]");
                    Console.ResetColor();
                    break;

                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ваш любимый цвет: [White]");
                    Console.ResetColor();
                    break;

                case "DarkBlue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Ваш любимый цвет: [DarkBlue]");
                    Console.ResetColor();
                    break;

                case "DarkRed":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ваш любимый цвет: [DarkRed]");
                    Console.ResetColor();
                    break;

                case "DarkGreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Ваш любимый цвет: [DarkGreen]");
                    Console.ResetColor();
                    break;

                case "DarkGray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Ваш любимый цвет: [DarkGray]");
                    Console.ResetColor();
                    break;

                case "DarkYellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ваш любимый цвет: [DarkYellow]");
                    Console.ResetColor();
                    break;

                case "DarkCyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ваш любимый цвет: [DarkCyan]");
                    Console.ResetColor();
                    break;

                case "DarkMagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Ваш любимый цвет: [DarkMagenta]");
                    Console.ResetColor();
                    break;

                default:
                    Console.WriteLine("Простите такова цвета нету");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
           
            OrderCode();
        } 

   
        // 2

        static void OrderCode()
        {
            byte count = 0;
            bool proverka = true;
            byte Correct = 0, Wrong = 0;


            while (proverka)
            {
                try
                {
                    Console.Write("Введите сколько будет раундов: ");
                    count = byte.Parse(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine("FormatException! Неизвестное число!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Clear();
                proverka = false;
            }


            Random random = new Random();
            byte number = 0;
            string color;

            for (int i = count; i > 0; i--)
            {
                Console.WriteLine("Осталось: " + i);
                number = (byte)random.Next(0, 15);

                switch (number)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "DarkRed")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (DarkRed)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "Blue")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (Blue)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "Red")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (Red)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "DarkBlue")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (DarkBlue)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "Green")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (Green)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "Gray")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (Gray)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "White")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (White)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 7:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "Magenta")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (Magenta)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 8:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "Cyan")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (Cyan)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 9:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "DarkYellow")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (DarkYellow)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 10:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "DarkGreen")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (DarkGreen)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 11:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "DarkMagenta")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (DarkMagenta)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 12:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "DarkCyan")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (DarkCyan)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 13:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "DarkGray")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (DarkGray)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 14:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "DarkRed")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (DarkRed)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;

                    case 15:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Угадай цвет: ");
                        color = Console.ReadLine();

                        if (color == "Yellow")
                        {
                            Console.WriteLine("Ответ верный");
                            Correct++;
                        }
                        else
                        {
                            Console.WriteLine("Ответ неверный. Правильный ответ это (Yellow)");
                            Wrong++;
                        }

                        Console.ResetColor();
                        break;
                }


                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Правильные ответы: " + Correct);
            Console.WriteLine("Неправильные ответы: " + Wrong);
            Console.ReadKey();
            Console.Clear();
          
            OrderCode2();
        }
    
        // 3   
        
        static void OrderCode2()
        {
            
            ushort height;
            ushort width;
            char sign;
            while (true)
            {
                try
                {
                    Console.Write("Введите высоту прямоугольника:\t");
                    height = Convert.ToUInt16(Console.ReadLine());

                    Console.Write("Введите ширину прямоугольника:\t");
                    width = Convert.ToUInt16(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуста, введите число.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите символ:\t");
                    sign = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуста, введите число.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }
            
            Console.Write("Введите цвет. На выбор (Red, Blue, Green, Yellow, White):  ");
            string color = Console.ReadLine();

            Console.Clear();

            switch (color)
            {
                case "Red":
                    for (int i = 0; i < height; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write(sign);
                        }
                        Console.WriteLine();
                    }
                    break;

                case "Blue":
                    for (int i = 0; i < height; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write(sign);
                        }
                        Console.WriteLine();
                    }
                    break;

                case "Green":
                    for (int i = 0; i < height; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write(sign);
                        }
                        Console.WriteLine();
                    }
                    break;

                case "Yellow":
                    for (int i = 0; i < height; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write(sign);
                        }
                        Console.WriteLine();
                    }
                    break;

                case "White":
                    for (int i = 0; i < height; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write(sign);
                        }
                        Console.WriteLine();
                    }
                    break;
            }
            Console.ResetColor();
            Console.ReadKey();


        }   
    }
}
