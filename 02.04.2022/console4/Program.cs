using System;
using System.IO;
using System.Text;

namespace console4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = ("C:\\Users\\frygus.S309.000\\Desktop\\C#\\02.04.2022\\filedir\\file.txt");

            string Name;
            string Surname;
            int Phonenumber;
            string Phonenumbertostring;
          

            Console.WriteLine("What's your name?");
            Name = Console.ReadLine();

            Console.WriteLine("What's your surname?");
            Surname = Console.ReadLine();

            Console.WriteLine("What's your phonenumber?");
            Phonenumbertostring = Console.ReadLine();

            Phonenumber = Convert.ToInt32(Phonenumbertostring);

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Name);
                    sw.WriteLine(Surname);
                    sw.WriteLine(Phonenumber);
                }
            }
        }
    }
}
