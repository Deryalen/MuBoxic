using System;
using System.Collections.Generic;

namespace MuBoxic
{
    [Serializable()]
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public List<Song> Songs;

        public Album (string name, DateTime date, List<Song> songs)
        {
            Name = name;
            Date = date;
            Songs = songs;
        }
    }

    [Serializable()]
    public class AlbumList : List<Album>
    {
        public int IdCounter;
        public new void Add(Album album)
        {
            base.Add(album);
            album.Id = IdCounter;
            IdCounter++;
        }

        public void AddToSecondary(Album album)
        {
            base.Add(album);
        }
    }
}