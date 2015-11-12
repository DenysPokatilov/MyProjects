using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProjects
{

    public class BasicExercises
    {

        public static void Main(string[] args)
        {
            new BasicExercises().Run(args);
        }

        public void Run(string[] args)
        {
            DisplayTasksMenu();
            string line;
            do
            {
                line = Console.ReadLine();
                if (line == null) { DisplayTasksMenu(); }
                if (line == "q" || line == "Q") { Console.WriteLine("See you next time! Aloha!"); Exit(); }
                else
                {
                    if (line == null)
                    {
                        DisplayTasksMenu();
                    }

                    else
                    {
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
                                StatisticsVowels();
                                break;
                            case "8": Console.WriteLine("Шифр Цезаря."); CaesarCipher();
                                break;
                        }
                    }


                }
                DisplayTasksMenu();

            } while (line.Length != 0);
        }

        public void Factorial()
        {
            Console.WriteLine("Введите число факториал которго вы хотели бы найти!");
            int value = int.Parse(Console.ReadLine());
            if (value == 0) { Console.WriteLine("особый случай, факториал  равен 1!"); }
            if (value < 0) { Console.WriteLine("ошибка! вы ввели отрицательное цисло"); }

            else
            {
                int factorial = 1;
                for (int i = 1; i <= value; i++)
                {
                    factorial = i * factorial;
                }
                Console.WriteLine("Факториал вашего числа равен {0}", factorial);
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
                    int nextValue = 1;
                    int value = 0;
                    int prevValue = 0;

                    for (i = 1; i < N; i++)
                    {
                        value = nextValue + prevValue;
                        prevValue = nextValue;
                        nextValue = value;
                        Console.Write("{0} ,", value);
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
            if (month == null)
            {
                Console.WriteLine("вы не выбрали язык ");
            }
            else
            {
                switch (month)
                {
                    case "1":
                        Console.WriteLine("Выберите номер месяца");
                        int inputRus = Convert.ToInt32(Console.ReadLine());
                        var elementRus = new Dictionary<int, string>();
                        elementRus.Add(1, "Январь"); elementRus.Add(2, "Февраль");
                        elementRus.Add(3, "Март"); elementRus.Add(4, "Апрель");
                        elementRus.Add(5, "Май"); elementRus.Add(6, "Июнь");
                        elementRus.Add(7, "Июль"); elementRus.Add(8, "Август");
                        elementRus.Add(9, "Сентябрь"); elementRus.Add(10, "Октябрь");
                        elementRus.Add(11, "Ноябрь"); elementRus.Add(12, "Декабрь");

                        foreach (KeyValuePair<int, string> item in elementRus)
                        {
                            if (inputRus == item.Key)
                            {
                                Console.WriteLine("{0}", item);
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Choose the number of month");
                        int inputEng = Convert.ToInt32(Console.ReadLine());
                        var elementEng = new Dictionary<int, string>();
                        elementEng.Add(1, "January"); elementEng.Add(2, "Februaury");
                        elementEng.Add(3, "March"); elementEng.Add(4, "April");
                        elementEng.Add(5, "May"); elementEng.Add(6, "june");
                        elementEng.Add(7, "July"); elementEng.Add(8, "Augest");
                        elementEng.Add(9, "September"); elementEng.Add(10, "October");
                        elementEng.Add(11, "November"); elementEng.Add(12, "December");

                        foreach (KeyValuePair<int, string> item in elementEng)
                        {
                            if (inputEng == item.Key)
                            {
                                Console.WriteLine("{0}", item);
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Sélectionnez le mois");
                        int inputFr = Convert.ToInt32(Console.ReadLine());
                        var elementFr = new Dictionary<int, string>();
                        elementFr.Add(1, "Janvier"); elementFr.Add(2, "Fevrier");
                        elementFr.Add(3, "Mars"); elementFr.Add(4, "Avril");
                        elementFr.Add(5, "Mai"); elementFr.Add(6, "Juin");
                        elementFr.Add(7, "Juillet"); elementFr.Add(8, "Aout");
                        elementFr.Add(9, "Septembre"); elementFr.Add(10, "Octobre");
                        elementFr.Add(11, "Novembre"); elementFr.Add(12, "Decembre");

                        foreach (KeyValuePair<int, string> item in elementFr)
                        {
                            if (inputFr == item.Key)
                            {
                                Console.WriteLine("{0}", item);
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Виберіть номер місяця");
                        int inputUkr = Convert.ToInt32(Console.ReadLine());
                        var elementUkr = new Dictionary<int, string>();
                        elementUkr.Add(1, "Сiчень"); elementUkr.Add(2, "Лютий");
                        elementUkr.Add(3, "Березень"); elementUkr.Add(4, "Квiтень");
                        elementUkr.Add(5, "Травень"); elementUkr.Add(6, "Червень");
                        elementUkr.Add(7, "Липень"); elementUkr.Add(8, "Серпень");
                        elementUkr.Add(9, "Вересень"); elementUkr.Add(10, "Жовтень");
                        elementUkr.Add(11, "Листопад"); elementUkr.Add(12, "Грудень");

                        foreach (KeyValuePair<int, string> item in elementUkr)
                        {
                            if (inputUkr == item.Key)
                            {
                                Console.WriteLine("{0}", item);
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("Wybierz miesiąc");
                        int inputPl = Convert.ToInt32(Console.ReadLine());
                        var elementPl = new Dictionary<int, string>();
                        elementPl.Add(1, "tyczeń"); elementPl.Add(2, "luty");
                        elementPl.Add(3, "marzec "); elementPl.Add(4, "kwiecień ");
                        elementPl.Add(5, "maj"); elementPl.Add(6, "czerwiec");
                        elementPl.Add(7, "lipiec"); elementPl.Add(8, "seirpien");
                        elementPl.Add(9, "wrzesień"); elementPl.Add(10, "wrzesień");
                        elementPl.Add(11, "listopad "); elementPl.Add(12, "listopad ");


                        foreach (KeyValuePair<int, string> item in elementPl)
                        {
                            if (inputPl == item.Key)
                            {
                                Console.WriteLine("{0}", item);
                            }
                        }
                        break;

                    default: Console.WriteLine("input is not correct");// на отдельной строке! 
                        break; // в ветке default это не нужно
                }
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
            string[] words = row.Split(new Char[] { ' ' });
            Console.WriteLine("В строке {0} слов", words.Length);
        }

        public void SearchWord()
        {
            Console.WriteLine(" Введите стоку из произвольного количества слов");
            string row = Console.ReadLine();
            string[] words = row.Split(new Char[] { ' ' });
            Console.WriteLine("Введите слово которое вы хотели бы найти в строке");
            string word = Console.ReadLine();
            for (int i = 1; i < words.Length - 1; i++)
            {
                if (words[i] == word)
                {
                    Console.WriteLine("да мы имеем слово - {0}, the number or row is {1}", word, i + 1);
                }
            }

        }

        public void StatisticsVowels()
        {
            Console.WriteLine("Введите строку для подсчета в ней гласных");
            string @string = Console.ReadLine();
            string vowels = "АаУуЕеОоЯяЭэИиЮю";
            if (@string == null) { Console.WriteLine("Вы не ввели строку для подсчета гласных букв"); }
            else
            {
                int counter = 0;
                for (int i = 0; i < @string.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (@string[i] == vowels[j])
                        {
                            Console.WriteLine("{0}-{1}", counter, @string[i]);
                            counter++;
                        }
                    }
                }
            }
        }

        public void CaesarCipher()
        {
            // Реализация шифра цезаря происходит при помощи замены буквы алфавита на ту букву,
            // номер которой указан после нее в алфавите со сдвигом вправо!
            // Exemple: мы выбрали букву G , то для нее мы берем букву, 
            // которая находиться через 2 символа алфавита , то есть G =>E =>F. Шифруем G как F
            Console.WriteLine("Unlike many of its sub-Saharan neighbors, however, which have embraced economic growth at the expense of environmental protections, Ethiopia has embarked on one of the world’s most ambitious green growth and climate mitigation programs.");
            string value = "Unlike many of its sub-Saharan neighbors, however, which have embraced economic growth at the expense of environmental protections, Ethiopia has embarked on one of the world’s most ambitious green growth and climate mitigation programs.";
            Console.WriteLine("величину сдвига равна 2  ");
            int shift = 2;

            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);

                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }

                buffer[i] = letter;
                Console.Write(letter);
            }

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

