using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
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
                if (line == null){DisplayTasksMenu();}
                if (line == "q"){Console.WriteLine("See you next time! Aloha!"); Exit();}
                else
                {   try {                   
                          switch (line)
                          {
                            case "1": Console.WriteLine(" Факториал."); Factorial();
                                break;
                            case "2": Console.WriteLine(" Ряд Фибоначчи."); Fibanachi();
                                break;
                            case "3": Console.WriteLine("Имя месяца по его номеру на указанном языке."); Months();
                                break;
                            case "4": Console.WriteLine("Перевернуть строку наоборот."); Flip();
                                break;
                            case "5": Console.WriteLine(" Посчитать количество слов в строке."); Count();
                                break;
                            case "6": Console.WriteLine("Поиск слова в строке."); SearchWord();
                                break;
                            case "7": Console.WriteLine("Статистика гласных в строке."); StatisticsVowels();
                                break;
                            case "8": Console.WriteLine("Шифр Цезаря."); CaesarCipher();
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
            { Console.WriteLine("вы не ввели значение факториала, Введите число факториал которго вы хотели бы найти!"); }
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
        {   Console.WriteLine("Введите число N для вычисления ряда Фибоначчи");
            int N = int.Parse(Console.ReadLine());
            {   if (N == 0)
                {
                    Console.WriteLine(" Число должно быть > 0");
                }
                else
                {   int i;
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

        public void Months()
        {
            Console.WriteLine("Choose the language ");
            Console.WriteLine("1 - Русский");
             Console.WriteLine("2 - English");
             Console.WriteLine("3 - Français");
             Console.WriteLine("4 - Український");
             Console.WriteLine("5 - Polskie");
             string month = Console.ReadLine();

            switch (month)
            {  case "1":
                    Console.WriteLine("Выберите номер месяца");
                    string number = Console.ReadLine();
                  //  var montH = new OrderedDictionary{ 
                  //  { "1","Январь"},
                  //  {"2","Февраль"}
                  // };
                    
                  //foreach (string number in montH)
                  //   {
                  //       Console.WriteLine("{0}"number);
                  //   } 
                  //  {
                  //      Console.WriteLine(number.);
                  //  }                                                      
            

                    break;
                case "2":
                    Console.WriteLine("Choose the number of month");
                    break;
                case "3":
                    Console.WriteLine("Sélectionnez le mois");
                    break;
                case "4":
                    Console.WriteLine("Виберіть номер місяця");
                    break;
                case "5":
                    Console.WriteLine("Wybierz miesiąc");
                    break;

                default: Console.WriteLine("Не правельный ввод");
                    break;
            } 
        }

        public void Flip()
        {
            Console.WriteLine("Введите строку для трасформации ");
            string input = Console.ReadLine();
            string output = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine(output);
        }

        public void Count()
        {
            Console.WriteLine(" Введите строку с производным количеством слов ");
            string row = Console.ReadLine();
            string [] words = row.Split(new Char [] {' '});            
            Console.WriteLine("В строке {0} слов" ,words.Length);                   
        }

        public void SearchWord()
        {
            Console.WriteLine(" Введите стоку из произвольного количества слов");
            string row = Console.ReadLine();
            string[] words = row.Split(new Char []{' '});
            Console.WriteLine("Введите слово которое вы хотели бы найти в строке");
            string word = Console.ReadLine();
            for (int i = 1; i < words.Length -1; i++)
            {        
                if (words[i]== word)
                {   
                    Console.WriteLine("да мы имеем слово - {0}, the number or row is {1}",word,i+1);
                }
            }

        }

        public void StatisticsVowels() 
        {
             //Console.WriteLine("Введите строку для подсчета в ней гласных");
            string row = "Покатилов Денис";
            string vowels = "АаУуЕеОоЯяЭэИиЮю";
            if (row == null) { Console.WriteLine("Вы не ввели строку для подсчета гласных букв"); }
            else
            {
                for (int i = 1; i < row.Length; i++)

                    for (int j = 1; j < vowels.Length; j++)
                    {
                        if (row[j] == vowels[i])
                        {
                            int count = 1;
                            Console.WriteLine("{0}-{1}", count, row[i]);
                            count++;
                        }
                    }
            }
        
        }
        //else { Console.WriteLine("В вашей строке гласных букв нет"); }
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