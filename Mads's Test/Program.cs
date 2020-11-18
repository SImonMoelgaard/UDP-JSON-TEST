
using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Mads_s_Test
{

    class Program
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
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {

                Movie movie = new Movie
                {
                    Name = "Bad Boys",
                    Year = 1995+1
                };

                // serialize JSON to a string and then write string to a file
                File.WriteAllText(@"C:\Users\memil\Documents\TestJson\test1.json", JsonConvert.SerializeObject(movie));
            }

            //// serialize JSON directly to a file
            //using (StreamWriter file = File.CreateText(@"c:\movie.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, movie);
            //}

        }
    }
}

