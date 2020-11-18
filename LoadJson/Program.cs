using System;
using System.IO;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LoadJson
{
    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return Name + " & " + Year;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {

                Load load = new Load();
                load.metod1();
            }
        }
    }
}
