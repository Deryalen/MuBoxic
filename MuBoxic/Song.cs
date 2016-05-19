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
        public string Date { get; set; }

        public Song(string name, string year)
        {
            Name = name;
            Date = year;
            id++;
        }
    }
}
