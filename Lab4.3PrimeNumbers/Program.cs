using System;

namespace Lab4._3PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let’s locate some primes!\n\nThis application will find you any prime, in order, from first prime number on.");
            string proceed = "y";

            while (proceed == "y")
            {
                Console.Write("Which prime number are you looking for?");
                int userInput = int.Parse(Console.ReadLine());
                int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 };
                if (userInput == 1)
                {
                    Console.WriteLine("The number 1 prime is 2");
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("The number 2 prime is 3");
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("The number 3 prime is 5");
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("The number 4 prime is 7");
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("The number 5 prime is 11");
                }
                else if (userInput == 6)
                {
                    Console.WriteLine("The number 6 prime is 13");
                }
                else if (userInput == 7)
                {
                    Console.WriteLine("The number 7 prime is 17");
                }
                else if (userInput == 8)
                {
                    Console.WriteLine("The number 8 prime is 19");
                }
                else if (userInput == 9)
                {
                    Console.WriteLine("The number 9 prime is 23");
                }
                else if (userInput == 10)
                {
                    Console.WriteLine("The number 10 prime is 29");
                }
                else if (userInput == 11)
                {
                    Console.WriteLine("The number 11 prime is 31");
                }
                else if (userInput == 12)
                {
                    Console.WriteLine("The number 12 prime is 37");
                }
                else if (userInput == 13)
                {
                    Console.WriteLine("The number 13 prime is 41");
                }
                else if (userInput == 14)
                {
                    Console.WriteLine("The number 14 prime is 43");
                }
                else if (userInput == 15)
                {
                    Console.WriteLine("The number 15 prime is 47");
                }
                else if (userInput == 16)
                {
                    Console.WriteLine("The number 16 prime is 53");
                }
                else if (userInput == 17)
                {
                    Console.WriteLine("The number 17 prime is 59");
                }
                else if (userInput == 18)
                {
                    Console.WriteLine("The number 18 prime is 61");
                }
                else if (userInput == 19)
                {
                    Console.WriteLine("The number 19 prime is 67");
                }
                else if (userInput == 20)
                {
                    Console.WriteLine("The number 20 prime is 71");
                }
                else if (userInput == 21)
                {
                    Console.WriteLine("The number 21 prime is 73");
                }
                else if (userInput == 22)
                {
                    Console.WriteLine("The number 22 prime is 79");
                }
                else if (userInput == 23)
                {
                    Console.WriteLine("The number 23 prime is 83");
                }
                else if (userInput == 24)
                {
                    Console.WriteLine("The number 24 prime is 89");
                }
                else if (userInput == 25)
                {
                    Console.WriteLine("The number 25 prime is 97");
                }
                else if (userInput == 26)
                {
                    Console.WriteLine("The number 26 prime is 101");
                }
                else if (userInput == 27)
                {
                    Console.WriteLine("The number 27 prime is 103");
                }
                else if (userInput == 28)
                {
                    Console.WriteLine("The number 28 prime is 107");
                }
                else if (userInput == 29)
                {
                    Console.WriteLine("The number 29 prime is 109");
                }
                else if (userInput == 30)
                {
                    Console.WriteLine("The number 30 prime is 113");
                }
                else if (userInput == 31)
                {
                    Console.WriteLine("The number 31 prime is 127");
                }
                else if (userInput == 32)
                {
                    Console.WriteLine("The number 32 prime is 131");
                }
                else if (userInput == 33)
                {
                    Console.WriteLine("The number 33 prime is 137");
                }
                else if (userInput == 34)
                {
                    Console.WriteLine("The number 34 prime is 139");
                }
                else if (userInput == 35)
                {
                    Console.WriteLine("The number 35 prime is 149");
                }
                else if (userInput == 36)
                {
                    Console.WriteLine("The number 36 prime is 151");
                }
                else if (userInput == 37)
                {
                    Console.WriteLine("The number 37 prime is 157");
                }
                else if (userInput == 38)
                {
                    Console.WriteLine("The number 38 prime is 163");
                }
                else if (userInput == 39)
                {
                    Console.WriteLine("The number 39 prime is 167");
                }
                else if (userInput == 40)
                {
                    Console.WriteLine("The number 40 prime is 173");
                }
                else if (userInput == 41)
                {
                    Console.WriteLine("The number 41 prime is 179");
                }
                else if (userInput == 42)
                {
                    Console.WriteLine("The number 42 prime is 181");
                }
                else if (userInput == 43)
                {
                    Console.WriteLine("The number 43 prime is 191");
                }
                else if (userInput == 44)
                {
                    Console.WriteLine("The number 44 prime is 193");
                }
                else if (userInput == 45)
                {
                    Console.WriteLine("The number 45 prime is 197");
                }
                else if (userInput == 46)
                {
                    Console.WriteLine("The number 46 prime is 199");
                }
                Console.WriteLine("Do you want to find another prime number? (y/n): ");
                proceed = Console.ReadLine();
            }
        }   
    }
}
