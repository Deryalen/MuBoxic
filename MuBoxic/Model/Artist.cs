using System;
using System.Collections.Generic;

namespace MuBoxic
{
    [Serializable()]
    class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime Year { get; set; }

        public readonly AlbumList Albums;

        public Artist (string name, string country, DateTime year, AlbumList albums)
        {
            Name = name;
            Country = country;
            Year = year;
            Albums = albums;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    [Serializable()]
    class ArtistList : List<Artist>
    {
        public int IdCounter;

        public new void Add(Artist artist)
        {
            base.Add(artist);
            artist.Id = IdCounter;
            IdCounter++;
        }

        public void AddToSecondary(Artist artist)
        {
            base.Add(artist);
        }
    }
}