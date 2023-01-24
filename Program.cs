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

            string temporaryVariable = firstName;
            firstName = lastName;
            lastName = temporaryVariable;

            Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}");
        }
    }
}
