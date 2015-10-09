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
            string url = args.Length == 0 ? null : args[0];
            while (url == null)
            {
                Console.WriteLine("Веедите url адрес");
                url = Console.ReadLine();
            }



            using (Stream responseStream = WebRequest.Create(url).GetResponse().GetResponseStream())
            {
                using (StreamReader responceReader = new StreamReader(responseStream))
                {
             
                    while (responceReader.Peek() >= 0)
                    {
                        Console.WriteLine(responceReader.ReadLine());
                    }
                }

            }
        }


    }
}







