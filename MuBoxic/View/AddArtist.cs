using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic.View
{
    public partial class AddArtist : Form
    {
        const string SongBase = @"SongBase.bin";
        const string AlbumBase = @"AlbumBase.bin";
        const string ArtistBase = @"ArtistBase.bin";

        public AddArtist()
        {
            InitializeComponent();
        }

        private SongList _songCacheList = new SongList();
        private AlbumList _albumCacheList = new AlbumList();
        private ArtistList _artistCacheList = new ArtistList();

        private void AddArtist_Load(object sender, EventArgs e)
        {
            if (File.Exists(SongBase))
            {
                Stream songFromFile = File.Open(SongBase, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                _songCacheList = (SongList) deserializer.Deserialize(songFromFile);
                songFromFile.Close();

                songs.DataSource = _songCacheList;

                if (File.Exists(AlbumBase))
                {
                    Stream albumFromFile = File.Open(AlbumBase, FileMode.Open);
                    _albumCacheList = (AlbumList) deserializer.Deserialize(albumFromFile);
                    albumFromFile.Close();

                    albums.DataSource = _albumCacheList;
                }
            }
            else
            {
                MessageBox.Show(@"There are no songs and albums. You can not add an artist!");
                Close();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            _songCacheList.Clear();
            _albumCacheList.Clear();

            foreach (Song song in songs.CheckedItems)
            {
                _songCacheList.AddToSecondary(song);
            }

            foreach (Album album in albums.CheckedItems)
            {
                _albumCacheList.AddToSecondary(album);
            }


            if (File.Exists(ArtistBase))
            {
                Stream fromFile = File.Open(ArtistBase, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                _artistCacheList = (ArtistList) deserializer.Deserialize(fromFile);
                fromFile.Close();
            }
            else
            {
                Stream create = File.Create(ArtistBase);
                create.Close();
            }

            if (name.TextLength != 0 && country.TextLength != 0)
            {
                int spacesInName = 0;
                int spacesInCountry = 0;
                for (int i = 0; i < name.TextLength; i++)
                {
                    if (name.Text[i] == ' ') spacesInName++;
                }
                for (int i = 0; i < country.TextLength; i++)
                {
                    if (country.Text[i] == ' ') spacesInCountry++;
                }
                if (spacesInName != name.TextLength && spacesInCountry != country.TextLength)
                {
                    Artist cacheArtist = new Artist();
                    if (_songCacheList.Count != 0 && _albumCacheList.Count != 0)
                    {
                        cacheArtist.Name = name.Text;
                        cacheArtist.Country = country.Text;
                        cacheArtist.Date = date.Value.Date;
                        cacheArtist.Songs = _songCacheList;
                        cacheArtist.Albums = _albumCacheList;
                    }
                    else if (_songCacheList.Count != 0)
                    {
                        cacheArtist.Name = name.Text;
                        cacheArtist.Country = country.Text;
                        cacheArtist.Date = date.Value.Date;
                        cacheArtist.Songs = _songCacheList;
                        cacheArtist.Albums = new AlbumList();
                    }
                    else if (_albumCacheList.Count != 0)
                    {
                        cacheArtist.Name = name.Text;
                        cacheArtist.Country = country.Text;
                        cacheArtist.Date = date.Value.Date;
                        cacheArtist.Albums = _albumCacheList;
                        cacheArtist.Songs = new SongList();
                    }

                    _artistCacheList.Add(cacheArtist);
                    MessageBox.Show(@"Done!");
                    name.Text = "";
                    country.Text = "";
                }
                else
                {
                    MessageBox.Show(@"Enter a correct name and country");
                }
            }
            else
            {
                MessageBox.Show(@"Enter the name of the artist and the country");
            }

            if (File.Exists(ArtistBase))
            {
                FileStream artistToFile = File.OpenWrite(ArtistBase);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(artistToFile, _artistCacheList);
                artistToFile.Close();
            }
            else
            {
                FileStream artistToFile = File.Create(ArtistBase);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(artistToFile, _artistCacheList);
                artistToFile.Close();
            }

            _songCacheList.Clear();
            _albumCacheList.Clear();
        }
    }
}
