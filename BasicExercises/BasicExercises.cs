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
<<<<<<< HEAD:BasicExercises/BasicExercises/Program.cs
                if (line == null) { DisplayTasksMenu(); }
                if (line == "q" || line == "Q") { Console.WriteLine("See you next time! Aloha!"); Exit(); }
                else
                {
=======
                // Каждая инструкция должна быть на отдельной строке! 
                if (line == null) { DisplayTasksMenu(); } // <- вот так вот не делай
                /*
                 * Разделяй отдельные блоки кода пустой строкой, как обычный человеческий текст разделяют на 
                 * отдельные абзацы! 
                 *
                 * Это помогает "перевести дыхание" между отдельными самостоятельными мыслями, выраженными 
                 * твоим кодом, а также легче воспринимается глазами и мозгом. Сплошной массив кода тяжело
                 * читать, так же, как и сплошной поток текста на целую страницу без единого абзаца.
                 *
                 * Например, эти два if'а вверху и внизу сливаются в один, и не сразу понятно, то ли это 
                 * два отдельных if'а, то ли один if, а второй относится к else, который почему-то не видно.
                 * Хотя в данном случае они всё же относятся к одной мысли, поэтому можно было бы свести в один if.
                 * Но опять же, это на твоё усмотрение. Возможно, ты хочешь отдельно сделать акцент на какой-то части
                 * мысли, поэтому разбиваешь её на два предложения. Или же, в нашем случае, на два отдельных if'а.
                 *
                 * Твой код - это особый способ выражения твоих мыслей, описывающих какой-то алгоритм или вообще какой-то
                 * объект или явление в мире. Это подобно тому, как какие-то химические, физические или математические 
                 * формулы тоже описывают в лаконичной форме какие-то явления в окружающем нас мире. Старайся это таки образом 
                 * воспринимать. Это важно не для компьютера - ему всё-равно, хоть ты в одну строку всё напиши. Прежде
                 * всего это важно для тебя самого в будущем, когда необходимо будет вернуться к старому коду, а также для
                 * других людей, которым придётся его читать и в нём разбираться. Не заставляй их тебя ненавидеть и проклинать ;) 
                 *
                 * Кстати, обрати внимание даже на этот мой коментарий. Ведь значительно легче и приятней его читать в таком виде,
                 * когда он разбит на отдельные небольшие абзацы, чем если бы я всё это написал сплошным потоком или вообще
                 * в одну строку, правда? ;)
                 */
                if (line == "q" | line == "Q") { Console.WriteLine("See you next time! Aloha!"); Exit(); }
                /*
                 * Неправильный оператор в условии if'а!
                 *
                 * Оператор, который ты использовал в условии - это на самом деле так называемое побитовое ИЛИ. Это не то же 
                 * самое и тебе на самом деле просто повезло, что это условие всё равно работает вроде как правильно (то есть
                 * правильно реагирует на "q" ИЛИ "Q"). Но это просто совпадение.
                 *
                 * Не буду особо расписывать, что это за побитовое ИЛИ, чтобы тебя не нагружать, так как оно тебе сейчас не 
                 * нужно, и может даже так получиться, что никогда не пригодится и не встретится в твоей карьере. Просто запомни
                 * хорошенько, что логическое И - это &&, а логическое ИЛИ - это || (ДВА символа & и |, соответственно).
                 */
                else {
>>>>>>> ab25cc4bfb377a06d782fe7011839d3f4e2f52f3:BasicExercises/BasicExercises.cs
                    try
                    {
                        switch (line)
                        {
                            // Опять же, каждая инструкция должна быть на отдельной строке, а не всё в одну!
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
                                break; // В ветке default break не нужен
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    /*
                     * Ты ни в одном из своих методов явным образом исключение не создаешь, чтобы его здесь 
                     * обрабатывать. Также не вижу, чтобы где-то могло ожидаться исключение в ситуации, 
                     * не зависящей от логики твоего кода и действий пользователя (например, при попытки 
                     * записи в файл, который в этот же момент может использоваться какой-то другой программой 
                     * и быть залоченным на изменения).
                     *
                     * Единственный случай, когда исключение может возникнуть, это если я введу какую-то
                     * строку, которая не является числом, а ты затем передаёшь это значение в метод 
                     * int.Parse() и уже этот метод создаёт исключение. Таким образом, лучше его где-то 
                     * там же и обрабатывать, где хотя бы понятно, что может быть исключение и вот ты 
                     * его обрабатываешь соответствующи образом. 
                     * 
                     * Перехватывать вот так вот абсолютно любые исключения где-нибудь на самом верхнем 
                     * уровне программы плохо, потому что непонятно, где они на самом деле могут возникнуть, 
                     * вследствие чего именно. Иногда у тебя может возникнуть ситуация, когда вот просто никак
                     * по-другому нельзя. В таком случае ничего не поделаешь. В случае с эти конкретно проектом
                     * у тебя есть доступ к редактированию всего кода, поэтому лучше сделать так, как я 
                     * объяснил выше.
                     */ 
                }
                DisplayTasksMenu();

            } while (line.Length != 0);
        }

        public void Factorial()
        {
            Console.WriteLine("Введите число факториал которго вы хотели бы найти!");
<<<<<<< HEAD:BasicExercises/BasicExercises/Program.cs
            int factorial = int.Parse(Console.ReadLine());
            if (factorial == 0){ Console.WriteLine("особый случай, факториал  равен 1!"); }
            if (factorial < 0) { Console.WriteLine("ошибка! вы ввели отрицательное цисло"  ); }
=======
            int factorial = int.Parse(Console.ReadLine()); // не очень удачное название переменной
            /*
             * На самом деле факториал - это значение, которое ты вычисляешь для введенного числа,
             * а не само это число, которое ты запрашиваешь у пользователя.
             * 
             * Исходя из описания задачи ("Поищи и найди, что такое факториал числа N..."), было бы
             * уместней назвать эту переменную N, или даже лучше n, чтобы это согласовалось с 
             * принятыми в С# naming conventions (я тебе писал как-то об этом раньше: Camel Case vs
             * Pascal Case и т. д.)
             */
            if (factorial == 0)
            { Console.WriteLine("вы не ввели значение факториала, Введите число факториал которго вы хотели бы найти!"); }
>>>>>>> ab25cc4bfb377a06d782fe7011839d3f4e2f52f3:BasicExercises/BasicExercises.cs
            else
            {
                int a = 1; // а вот эту переменную как раз было бы уместней назвать factorial
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
                    /**
                     * 1. Комментарии - это хорошо, но только для каких-то нетривиальных вещей.
                     * Есть такая мудрость, которая гласит, что лучший комментарий - это твой код.
                     * Это не значит, что следует забить на комментарии и никогда их не писать,
                     * а наоборот, следует так писать свой код, такие выбирать имена для переменных
                     * и методов, чтобы по ним было всё понятно и не было необходимости в комментариях.
                     *
                     * Например, почему бы вместо x и m не назвать эти переменные nextValue и prevValue
                     * соответственно? Ну, или просто next и prev для краткости? В таком случае не было
                     * бы необходимости в комментариях, так как из самих имён всё понятно, а также значительно
                     * легче читался бы дальнейшмй код, который их использует.
                     *
                     * 2. Почему x, y и m у тебя типа double? Ведь числа, составляющие ряд Фибоначчи для 
                     * некоего целого N, могут быть только целыми. Дробных чисел быть не может, поэтому
                     * double здесь абсолютно ни к чему, а правильней было бы использовать какой-нибудь
                     * целочисленный тип (например, int).
                     */
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
                            /** 
                             * Convert.ToInt32() никогда не возвращает null, так как int - это
                             * целочисленный non nullable тип. Таким образом, это условие бесполезно,
                             * так как в него невозможно попасть.
                             */
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
                            // См. мой комментарий по поводу этого условия выше. Он так же относится
                            // ко всем следующим блоками ниже (не буду дальше копировать).
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

                    default: Console.WriteLine("input is not correct"); // на отдельной строке!
                        break; // в ветке default это не нужно
                }
            }
        }

        public void Flip()
        {
            Console.WriteLine("Введите строку для трасформации ");
            string input = Console.ReadLine();
            string output = new string(input.ToCharArray().Reverse().ToArray()); // ишь, какой хитренький! :D
            // Но всё правильно - я ведь ничего не сказал о том, чтобы использовать или нет встроенные классы и методы,
            // поэтому всё верно: не надо изобретать велосипед, если уже есть готовые решения :)
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
            string stroka = Console.ReadLine(); // это что ещё за новое слово в английском языке? ;)
            /**
             * Всегда используй только английский язык в коде, никаких русских названий и транслита! 
             * Во-первых, это считается дурным тоном. 
             *
             * Во-вторых, если когда-нибудь с твоим кодом придётся работать кому-то, кто не говорит по-русски, 
             * то будь уверен, этот несчастный сделает для тебя куколку вуду и натыкает в неё иголок! ;)
             * 
             * Это правило актуально даже если работаешь исключительно с украинцами. Я, например, за
             * такие фокусы немедленно предаю человека анафеме! ;)
             */
            string vowels = "АаУуЕеОоЯяЭэИиЮю";
            if (stroka == null) { Console.WriteLine("Вы не ввели строку для подсчета гласных букв"); }
            else
            {
                int counter = 0;
                for (int i = 0; i < stroka.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (stroka[i] == vowels[j])
                        {
                            Console.WriteLine("{0}-{1}", counter, stroka[i]);
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

            if (value == null)
            {
                // Это условие и весь блок в данном случае бесполезны, так как ты прямо несколькими
                // строками выше присваиваешь переменной value текстовое значение.
                Console.WriteLine("данные для шифрования отсутствуют");
            }
            else
            {
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
            // Загадочный метод... Я так и не понял, зачем зачем ты решил его использовать.
            // Просвети, пожалуйста ;)
            Environment.Exit(0);
        }

    }

}


