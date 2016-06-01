using System;
using System.Collections.Generic;

namespace MuBoxic
{
    [Serializable()]
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime Date { get; set; }

        public AlbumList Albums;
        public SongList Songs;

        public Artist()
        {
            
        }

        public Artist(string name, string country, DateTime date, SongList songs, AlbumList albums)
        {
            Name = name;
            Country = country;
            Date = date;
            Songs = songs;
            Albums = albums;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    [Serializable()]
    public class ArtistList : List<Artist>
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