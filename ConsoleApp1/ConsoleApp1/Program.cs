using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string segmentPath = @"assets\img\services\americano";
            string path = $@"C:\Users\gcuervo\Desktop\dd\{segmentPath}";
            string segmentTemplate = $@"<div class=""item"">
    <img src = ""{segmentPath.Replace('\\', '/')}/{{0}}"" >
</div>";
            foreach (var fileName in Directory.EnumerateFiles(path))
                Console.WriteLine(segmentTemplate, Path.GetFileName(fileName));
        }
    }
}
