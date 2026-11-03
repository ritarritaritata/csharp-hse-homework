using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Enter your birth year: ");
    int birthYear = int.Parse(Console.ReadLine());

    // 2. вычисляем возраст
    int age = 2026 - birthYear;

    // 3. приветствие и возраст
    Console.WriteLine($"Hello, {name}!");
    Console.WriteLine($"You are {age} years old.");

    // 4. имя в верхнем регистре и его длина
    Console.WriteLine($"Your name in uppercase: {name.ToUpper()}");
    Console.WriteLine($"Your name has {name.Length} characters.");
  }
}
