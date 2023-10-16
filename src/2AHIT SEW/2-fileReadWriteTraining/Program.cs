using System;
using System.IO;

namespace _2_fileReadWriteTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\TextFiles\demo.txt");
            string data;
            try
            {
               
                data = reader.ReadLine(); //will give the first line

                while (data != null) //ad long as there are lines in the file it should put it out on console
                {
                    Console.WriteLine(data); // output
                    data = reader.ReadLine(); //make the variable the next line
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
            }
            




        }
    }
}
