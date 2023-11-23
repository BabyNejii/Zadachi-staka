using System;

namespace _23._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZADACHA 1
            string name = "Ivo";
            int age = 17;


            //ZADACHA 2
            if (age >= 18)
            {
                Console.WriteLine("Pylnoleten");
            }
            else
            {
                Console.WriteLine("Nepylnoleten");
            }


            //ZADACHA 3
            int i = 0;
            while (i >= 10)
            {
                Console.WriteLine("The variable is now equal to " + i);
                i = i + 1;
            }


            //ZADACHA 4
            string[] cvetove = { "Zelen", "Sin", "Cherven" };


            //ZADACHA 5
            cvetove[2] = "Jylt";
            

            //ZADACHA 6
            foreach(string cvqt in cvetove)
            {
                Console.WriteLine(cvqt);
            }



            //ZADACHA 7
            string[] prazen = new string[5];


            //ZADACHA 8 
            Function();


            //zadacha 9
            Ime(name);


            //ZADACHA 10
            int result = addnumbers(5, 7);
            Console.WriteLine("The result is " + result);

        }
        public static void Function()
        {
            Console.WriteLine("Az sym funkciq");
        }


        public static void Ime(string name)
        {
            Console.WriteLine("Zdr " + name);
        }


        static int addnumbers(int a,int b)
        {
            return (a + b);
        }
    }
}
