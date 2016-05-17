using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuBoxic
{
    class Artist
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }

        public readonly List<Album> Albums;

        public Artist (string name, string country, int year)
        {
            Name = name;
            Country = country;
            Year = year;
        }
    }
}