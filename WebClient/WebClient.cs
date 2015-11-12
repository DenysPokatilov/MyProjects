using System;
using System.IO;
using System.Net;

namespace MyProjects
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
                Console.WriteLine("Введите URL");
                url = Console.ReadLine();
            }

            using (Stream responseStream = WebRequest.Create(url).GetResponse().GetResponseStream())
            {
                using (StreamReader responseReader = new StreamReader(responseStream))
                {
             
                    while (responseReader.Peek() >= 0)
                    {
                        Console.WriteLine(responseReader.ReadLine());
                    }
                }

            }
        }

    }

}