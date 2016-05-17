using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuBoxic
{
    class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public readonly List<Song> Songs;

        public Album (string name, int year, List<Song> songs)
        {
            Name = name;
            Year = year;
            Songs = songs;
        }
    }
}