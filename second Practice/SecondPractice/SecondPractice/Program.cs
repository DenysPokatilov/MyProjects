using System;

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
            
              int factorial =Convert.ToInt32( Console.ReadLine());
              if (factorial == null)
              {
                  Console.WriteLine("в не ввели значение факториала, Введите число факториал которго вы хотели бы найти!");
              }
              else
              {
                  int a = 1;
                  for (int i = 0; i <= factorial; i++)
                  {
                      a *= i;
                  }
                  Console.WriteLine(a);
              }
          
          
          }

        public void Fibanachi() { }

        public void Months() { }

        public void Flip() { }

        public void Count() { }

        public void SearchWord() { }

        public void Statistics() { }

        public void CaesarCipher() { }

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