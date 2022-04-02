using System;
using System.IO;

namespace console3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("");

            string lineWrittenfromfile = streamReader.ReadToEnd();
            Console.WriteLine(lineWrittenfromfile);

            Console.WriteLine("click any key to DESTROY the file");
            Console.ReadKey();
            streamReader.Dispose();
            Console.WriteLine("The file is no longer among us");
            Console.ReadKey();
         }
    }
}
