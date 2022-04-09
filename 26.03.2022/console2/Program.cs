using System;

namespace konsola2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What task");

            int tasknumber;
            string taskstring;
            taskstring = Console.ReadLine();
            tasknumber = Convert.ToInt32(taskstring);
            switch (tasknumber)
            {
                case 1:
                    uno();
                    break;
                case 2:
                    dos();
                    break;
                case 3:
                    tres();
                    break;
                case 4:
                    quadro();
                    break;
                case 5:
                    sinco();
                    break;
            }
                           
        }
        static void uno() {
            string name;
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            int index = name.Length;

            if (name[0] == 'm')
            {
                Console.WriteLine("Your name starts with an m");
            }

            if (name[index - 1] == 'a')
            {
                Console.WriteLine("Your name ends with an a");
            }
        }

        static void dos()
        {
            Console.WriteLine("Give me your name");
            string name;
            name = Console.ReadLine();
            int namelong;

            namelong = name.Length;

            if(namelong == 10) {
                Console.WriteLine("Your name has 10 characters");
            }
            else
            {
                Console.WriteLine("Your name does't have 10 characters");
            }
        }

        static void tres()
        {
       
            int a;    
            int b;
            string astring;
            Console.WriteLine("Give me the first number");
            astring = Console.ReadLine();
            string bstring;
            Console.WriteLine("Give me the second number");
            bstring = Console.ReadLine();

            a = Convert.ToInt32(astring);
            b = Convert.ToInt32(bstring);

            
            Console.WriteLine(a);
            Console.WriteLine(b);
         
        }

        static void quadro()
        {
            double a;
            double b;
            string astring;
            Console.WriteLine("Give me the first number");
            astring = Console.ReadLine();
            string bstring;
            Console.WriteLine("Give me the first number");
            bstring = Console.ReadLine();

            a = Convert.ToDouble(astring);
            b = Convert.ToDouble(bstring);
            double outcome;
            
            Console.WriteLine("What equasion ? [*,+,-,/]");
            string mathsign;
            mathsign = Console.ReadLine();

            switch (mathsign)
            {
                case "*":
                    outcome = a * b;
                    Console.WriteLine(outcome);
                    break;
                case "/":
                    outcome = a / b;
                    Console.WriteLine(outcome);
                    break;
                case "+":
                    outcome = a + b;
                    Console.WriteLine(outcome);
                    break;
                case "-":
                    outcome = a - b;
                    Console.WriteLine(outcome);
                    break;
            }
        }

        static void sinco()
        {
            Console.WriteLine("Give me 10 words");
            string userwords = Console.ReadLine();

            string[] table = userwords.Split(';');
            if(table.Length == 10)
            {
                for (int i = 0; i < table.Length; i += 2)
                {
                    Console.WriteLine(table[i]);
                }
            }
            else
            {
                Console.WriteLine("You didn't give me 10 words");
            }
        }
    }
}
