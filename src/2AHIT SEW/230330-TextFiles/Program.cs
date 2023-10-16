using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _230330_TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\TextFiles\demo.txt";

            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();
                newPerson.Vorname = entries[0];
                newPerson.Nachname = entries[1];
                newPerson.URL = entries[2];
                people.Add(newPerson);
            }

            Console.WriteLine("Read from text file");
            foreach (var person in people)
            {

                Console.WriteLine($"{person.Vorname} {person.Nachname}:{person.URL}");
            }

            people.Add(new Person { Vorname = "Greg", Nachname = "Jones", URL = "www.test.de" });

            List<string> output = new List<string>();

            foreach (var person in people)
            {

                output.Add($"{person.Vorname},{person.Nachname},{person.URL}");
            }
            File.WriteAllLines(filepath, output);

            Console.ReadLine();
        }
    }
}
