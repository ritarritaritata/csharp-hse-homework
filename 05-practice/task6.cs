using System;

class Program
{
    static void Main(string[] args)
    {
        string data = "x=10;y=20;z=30";

        foreach (string part in data.Split(';'))
        {
            string[] pair = part.Split('=');
            Console.WriteLine($"Coordinate {pair[0]} = {pair[1]}");
        }
    }
}
