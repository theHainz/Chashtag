using System;
using System.IO;


namespace console4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = ("");

            Console.WriteLine("What do you want to do with the file?");
            Console.WriteLine("You can 'writeinfile', ");
            string answer;
            answer = Console.ReadLine();

            switch (answer)
            {
                case "writeinfile":
                    writeinfile(path);
                    break;
            }
        }

        static void writeinfile(string path) {

            string name;
            string surname;
            int phonenumber;
            string phonenumbertostring;
            


            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

            Console.WriteLine("What's your surname?");
            surname = Console.ReadLine();

            Console.WriteLine("What's your phonenumber?");
            phonenumbertostring = Console.ReadLine();

            phonenumber = Convert.ToInt32(phonenumbertostring);
                
            // count the line number.
            int counter = 0;

            StreamReader streamReader = new StreamReader(path);
            while (streamReader.ReadLine() != null)
            {
                counter++;
            }

            streamReader.Close();

            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine($"{counter} {name} {surname} {phonenumber}");
                }
            }
            else if (File.Exists(path))
            {
                File.Delete(path);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine($"{counter} {name} {surname} {phonenumber}");
                }
            }
        }
    }
}
