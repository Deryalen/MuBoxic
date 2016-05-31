using System;
using System.Collections.Generic;

namespace MuBoxic
{
    [Serializable()]
    public class Song
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }

        public static int DeletedCounter { get; set; }

        public Song(string name, DateTime year)
        {
            Name = name;
            Date = year;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable()]
    public class SongList : List<Song>
    {
        public int IdCounter;

        public new void Add(Song song)
        {
            base.Add(song);
            song.Id = IdCounter;
            IdCounter++;
        }

        public void AddToSecondary(Song song)
        {
            base.Add(song);
        }

        public new void RemoveAt(int index)
        {
            base.RemoveAt(index);
            IdCounter--;
            Song.DeletedCounter++;
        }
    }
}
