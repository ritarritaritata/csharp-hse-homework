using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "level_01_scene.unity";

        int dotIndex = fileName.IndexOf('.');            // 14
        string name = fileName.Substring(0, dotIndex);   // "level_01_scene"
        string upperName = name.ToUpper();               // "LEVEL_01_SCENE"

        Console.WriteLine(upperName);
    }
}
