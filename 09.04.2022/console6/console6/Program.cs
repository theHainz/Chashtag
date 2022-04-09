using System;

namespace console6
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.Haircolour = "blond";
            human.Eye = "blue";
            human.Age = 16;

            Human human2 = new Human();
            human2.Haircolour = "dark";
            human2.Eye = "brown";
            human2.Age = 25;
            
            Console.WriteLine("Human");
            Console.WriteLine(human.Haircolour);
            Console.WriteLine(human.Eye);
            Console.WriteLine(human.Age);
            Console.WriteLine("");
            Console.WriteLine("Human2");
            Console.WriteLine(human2.Haircolour);
            Console.WriteLine(human2.Eye);
            Console.WriteLine(human2.Age);
        }

        class Human
        {
            public string Haircolour;
            public int Age;
            public string Eye;
            
        }
    }
}