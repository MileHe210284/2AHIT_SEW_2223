using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _230418_Ü24_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("Testfile.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("the file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
