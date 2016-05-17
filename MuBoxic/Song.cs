using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuBoxic
{
    class Song
    {
        public static int counter = 0;
        public int ID;
        public string Name { get; set; }
        public int Year { get; set; }

        public Song(string name, int year) : this(++counter, name, year) { }


        public Song(int ID, string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}
