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
                        
            if (args.Length == 0)
            {
                DisplayTasksMenu();
            }
            else
            {
                try
                {
                    string commands = Console.ReadLine();
                    switch (commands)
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

                        if (inputRus == null)
                        {
                            Console.WriteLine("вы не ввели элемент");
                        }
                        else
                        {
                            foreach (KeyValuePair<int, string> item in elementRus)
                            {
                                if (inputRus == item.Key)
                                {
                                    Console.WriteLine("{0}", item);
                                }
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

                        if (inputEng == null)
                        {
                            Console.WriteLine("you did'not enter the number of month");
                        }

                        else
                        {
                            foreach (KeyValuePair<int, string> item in elementEng)
                            {
                                if (inputEng == item.Key)
                                {
                                    Console.WriteLine("{0}", item);
                                }
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

                        if (inputFr == null)
                        {
                            Console.WriteLine("Vous no avez pas entré numero le mois");
                        }
                        else
                        {
                            foreach (KeyValuePair<int, string> item in elementFr)
                            {
                                if (inputFr == item.Key)
                                {
                                    Console.WriteLine("{0}", item);
                                }
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

                        if (inputUkr == null)
                        {
                            Console.WriteLine("Ви не зробили введеня номера мiсяця");
                        }
                        else
                        {
                            foreach (KeyValuePair<int, string> item in elementUkr)
                            {
                                if (inputUkr == item.Key)
                                {
                                    Console.WriteLine("{0}", item);
                                }
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

                        if (inputPl == null)
                        {
                            Console.WriteLine("Nie wpisałeś miesiąc");
                        }
                        else
                        {
                            foreach (KeyValuePair<int, string> item in elementPl)
                            {
                                if (inputPl == item.Key)
                                {
                                    Console.WriteLine("{0}", item);
                                }
                            }
                        }
                        break;

                    default: Console.WriteLine("input is not correct");
                        break;
                }
            }
        }

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

        }

    }

}