using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Иванов";
            string lastName = "Иван";

            Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}");

            string x = firstName;
            firstName = lastName;
            lastName = x;

            Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}");
        }
    }
}
