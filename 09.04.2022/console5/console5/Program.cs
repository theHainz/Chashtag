using System;
using System.Collections.Generic;

namespace console5
{
    class Program
    {
        static void Main(string[] args)
        {
            //el
            string[] givenNames = new string[3];
            List<string> givenNamesList = new List<string>();
            int limit = 10000;
            int counter = 0;

            while(counter < limit)
            {
                Console.WriteLine("Current List length");
                Console.WriteLine(givenNamesList.Count);
                Console.WriteLine("Gib Name");
                string Name = Console.ReadLine();
                givenNamesList.Add(Name);
                //currentindex++
                Console.Clear();
            }
        }

        static string[] AddtoTable(string[] table, string newElement)
        {
            string[] NewTable = new string[table.Length + 1];
            for (int i = 0; i < table.Length; i++)
            {
                NewTable[i] = table[i];
            }

            NewTable[NewTable.Length - 1] = newElement;
            return NewTable;
            
        }
    }
}
