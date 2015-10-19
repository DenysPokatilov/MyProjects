using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace BasicExercises
{

    public class Program
    {


        public static void Main(string[] args)
        {
            new Program().Run(args);
        }
        public void Run(string[] args)
        {
            DisplayTasksMenu();

            string line;

            do
            {
                line = Console.ReadLine();

                if (line.Length == 0)
                {
                    DisplayTasksMenu();
                }
                if (line == "q")
                {
                    Console.WriteLine("See you next time! Aloha!");
                    Exit();
                }
                else
                {
                    try
                    {
                        //string commands = Console.ReadLine();
                        switch (line)
                        {
                            case "1": Console.WriteLine(" Факториал.");
                                Factorial();
                                break;
                            case "2": Console.WriteLine(" Ряд Фибоначчи.");
                                Fibanachi();
                                break;
                            case "3": Console.WriteLine("Имя месяца по его номеру на указанном языке.");
                                Months();
                                break;
                            case "4": Console.WriteLine("Перевернуть строку наоборот.");
                                Flip();
                                break;
                            case "5": Console.WriteLine(" Посчитать количество слов в строке.");
                                Count();
                                break;
                            case "6": Console.WriteLine("Поиск слова в строке.");
                                SearchWord();
                                break;
                            case "7": Console.WriteLine("Статистика гласных в строке.");
                                Statistics();
                                break;
                            case "8": Console.WriteLine("Шифр Цезаря.");
                                CaesarCipher();
                                break;
                            default:
                                Console.WriteLine("Неправельный ввод!!!");
                                break;
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }


                Console.ReadLine();


            } while (line.Length != 0);

        }


        public void Factorial()
        {
            Console.WriteLine("Введите число факториал которго вы хотели бы найти!");

            int factorial = int.Parse(Console.ReadLine());
            if (factorial == 0)
            {
                Console.WriteLine("вы не ввели значение факториала, Введите число факториал которго вы хотели бы найти!");
            }
            else
            {
                int a = 1;
                for (int i = 1; i <= factorial; i++)
                {
                    a = i * a;
                }
                Console.WriteLine("Факториал вашего числа равен {0}", a);
            }


        }

        public void Fibanachi()
        {
            Console.WriteLine("Введите число N для вычисления ряда Фибоначчи");

            int N = int.Parse(Console.ReadLine());

            {
                if (N == 0)
                {
                    Console.WriteLine(" Число должно быть > 0");
                }
                else
                {
                    int i;
                    double x = 1; // начальное значение
                    double y = 0;
                    double m = 0; // для предыдущего числа
                    for (i = 1; i < N; i++)
                    {
                        y = x + m;
                        m = x;
                        x = y;
                        Console.Write("{0} ,", y);
                    }


                }
            }


        }

        public void Months() { }

        public void Flip() { }

        public void Count() { }

        public void SearchWord() { }

        public void Statistics() { }

        public void CaesarCipher()
        {
            // Реализация шифра цезаря происходит при помощи замены буквы алфавита на ту букву,
            // номер которой указан после нее в алфавите со сдвигом вправо!
            // Exemple: мы выбрали букву G , то для нее мы берем букву, 
            // которая находиться через 2 символа алфавита , то есть G =>E =>F. Шифруем G как F

            Console.WriteLine("Unlike many of its sub-Saharan neighbors, however, which have embraced economic growth at the expense of environmental protections, Ethiopia has embarked on one of the world’s most ambitious green growth and climate mitigation programs.");
            Console.WriteLine();
            string s = "Unlike many of its sub-Saharan neighbors, however, which have embraced economic growth at the expense of environmental protections, Ethiopia has embarked on one of the world’s most ambitious green growth and climate mitigation programs.";
            Console.WriteLine("величину сдвига равна 2  ");

            uint shift = 2;
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                //Если не кириллица
                if (((int)(s[i]) < 1040) || ((int)(s[i]) > 1103))
                    result += s[i];
                //Если буква является строчной
                if ((Convert.ToInt16(s[i]) >= 1072) && (Convert.ToInt16(s[i]) <= 1103))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(s[i]) + shift > 1103)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(s[i]) + shift - 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(s[i]) + shift);
                }
                //Если буква является прописной
                if ((Convert.ToInt16(s[i]) >= 1040) && (Convert.ToInt16(s[i]) <= 1071))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(s[i]) + shift > 1071)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(s[i]) + shift - 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(s[i]) + shift);
                }
            }
            //Вывод на экран зашифрованной строки
            Console.WriteLine("Строка успешно зашифрована!");
            Console.WriteLine(result);
        }



        public void DisplayTasksMenu()
        {
            Console.WriteLine("Введи номер задачи из списка или q для выхода:");
            Console.WriteLine("");
            Console.WriteLine("1. Факториал.");
            Console.WriteLine("2. Ряд Фибоначчи.");
            Console.WriteLine("3. Имя месяца по его номеру на указанном языке.");
            Console.WriteLine("4. Перевернуть строку наоборот.");
            Console.WriteLine("5. Посчитать количество слов в строке.");
            Console.WriteLine("6. Поиск слова в строке.");
            Console.WriteLine("7. Статистика гласных в строке.");
            Console.WriteLine("8. Шифр Цезаря.");
            Console.WriteLine("");
        }
        public void Exit()
        {
            Environment.Exit(0);
        }

    }

}


//  string input = args.Length == 0 ? null : args[0]; 