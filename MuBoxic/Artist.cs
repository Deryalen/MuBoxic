using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuBoxic
{
    [Serializable()]
    class Artist
    {
        public static int id = 0;
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime Year { get; set; }

        public readonly List<Album> Albums;

        public Artist (string name, string country, DateTime year, List<Album> albums)
        {
            Name = name;
            Country = country;
            Year = year;
            Albums = albums;
            id++;
        }

        [Serializable()]
        class ArtistList : List<Artist>
        {
            
        }
    }
}