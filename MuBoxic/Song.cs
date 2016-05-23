using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuBoxic
{
    [Serializable()]
    public class Song
    {
        public static int id = 0;
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Song(string name, DateTime year)
        {
            Name = name;
            Date = year;
            id++;
        }
    }

    [Serializable()]
    public class SongList : List<Song>
    {

    }
}
