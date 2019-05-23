using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace pen_data_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new WarscrollsParsers();

            var scrolls = parser.Parse("resources/stormcast-data.txt");

            var jsonData = JsonConvert.SerializeObject(scrolls);

            Directory.CreateDirectory("parsed-data");
            var fileName = $"parsed-data/stormcast-data-{DateTime.UtcNow.ToString("yyyyMMddhhmmsss")}.json";
            File.WriteAllText(fileName, jsonData, Encoding.UTF8);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
