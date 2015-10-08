using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace MyPractice
{

    public class WebClient
    {
        static void Main(string[] args)
        {
            new WebClient().Run(args);
        }

        public void Run(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Enter any url adress, like this type http://www.vk.com");
            }
            else
            {
                Console.ReadLine();
                foreach (var arg in args)
                {
                    if (arg == "-url")
                    {
                       
                        using (Stream responceStream = WebRequest.Create(arg).GetResponse().GetResponseStream())

                        using (StreamReader responceReader = new StreamReader(responceStream))
                        {
                            Console.WriteLine("It works!");
                            while (responceReader.Peek() >= 0)
                            {
                                Console.WriteLine(responceReader.ReadLine());
                            }
                        }
                    }

                    Console.ReadKey();
                }

            }


        }
    }
}



