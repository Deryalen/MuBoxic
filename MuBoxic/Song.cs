using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuBoxic
{
    class Song
    {
        public static int id = 0;
        public string Name { get; set; }
        public int Year { get; set; }

        public Song(string name, int year)
        {
            Name = name;
            Year = year;
            id++;
        }
    }
}
