using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic.View
{
    public partial class AddAlbum : Form
    {

        const string SongBase = @"SongBase.bin";
        const string AlbumBase = @"AlbumBase.bin";

        public AddAlbum()
        {
            InitializeComponent();
        }


        private SongList _songCacheList = new SongList();

        private AlbumList _albumCacheList = new AlbumList();

        private void AddAlbum_Load(object sender, EventArgs e)
        {
            if (File.Exists(SongBase))
            {
                Stream fromFile = File.Open(SongBase, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                _songCacheList = (SongList)deserializer.Deserialize(fromFile);
                fromFile.Close();
                songs.DataSource = _songCacheList;
            }
            else
            {
                MessageBox.Show(@"There are no songs. You can not add an album!");
                Close();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            _songCacheList.Clear();

            foreach (Song song in songs.CheckedItems)
            {
                _songCacheList.AddToSecondary(song);
            }

            if (File.Exists(AlbumBase))
            {
                Stream fromFile = File.Open(AlbumBase, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                _albumCacheList = (AlbumList)deserializer.Deserialize(fromFile);
                fromFile.Close();
            }
            else
            {
                Stream create = File.Create(AlbumBase);
                create.Close();
            }

            if (name.TextLength != 0)
            {
                int spaces = 0;
                for (int i = 0; i < name.TextLength; i++)
                {
                    if (name.Text[i] == ' ') spaces++;
                }
                if (spaces != name.TextLength)
                {
                    Album cacheAlbum = new Album(name.Text, date.Value.Date, _songCacheList);
                    _albumCacheList.Add(cacheAlbum);
                    MessageBox.Show(@"Done!");
                    name.Text = "";


                }
                else
                {
                    MessageBox.Show(@"Enter a correct name");
                }
            }
            else
            {
                MessageBox.Show(@"Enter the name of the album");
            }

            if (File.Exists(AlbumBase))
            {
                FileStream toFile = File.OpenWrite(AlbumBase);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(toFile, _albumCacheList);
                toFile.Close();
            }
            else
            {
                FileStream toFile = File.Create(AlbumBase);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(toFile, _albumCacheList);
                toFile.Close();
            }

            _songCacheList.Clear();
        }
    }
}
