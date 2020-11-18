using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace LoadJson
{
    class Load
    {
        public void metod1()
        {
            // read file into a string and deserialize JSON to a type
            Movie movie1 = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(@"C:\Users\memil\Documents\TestJson\test.json"));

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"C:\Users\memil\Documents\TestJson\test1.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Movie movie2 = (Movie)serializer.Deserialize(file, typeof(Movie));
            Console.WriteLine(movie2.ToString());
            }

        }
    }
}
