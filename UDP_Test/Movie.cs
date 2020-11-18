using System;
using System.Collections.Generic;
using System.Text;

namespace UDP_Test
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
}
