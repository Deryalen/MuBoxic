using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuBoxic
{
    class Album
    {
        public static int id = 0;
        public string Name { get; set; }
        public DateTime Year { get; set; }

        public readonly List<Song> Songs;

        public Album (string name, DateTime year, List<Song> songs)
        {
            Name = name;
            Year = year;
            Songs = songs;
            id++;
        }
    }
}