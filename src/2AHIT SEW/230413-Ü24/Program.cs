using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _230413_Ü24
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\TextFiles\";
            try
            {
                if (FileStyleUriParser.Exists(path))
                {
                    FileStyleUriParser.Delete(path);
                }

                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is some text");
                    sw.WriteLine("to test");
                    sw.WriteLine("Reading");
                }

                using(StreamReader sr =new StreamReader(path))
                {
                    while(sr.Peek() >= 0)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The process failed : {0}", e.ToString());
            }
        }
    }
}
