using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic.View
{
    public partial class SongInfo : Form
    {
        const string SongBase = @"SongBase.bin";
        const string AlbumBase = @"AlbumBase.Bin";

        private string _cacheName;
        private DateTime _cacheDate;

        private SongList _toEditSongList = new SongList();

        private readonly Song _toShowSong;

        private AlbumList _cacheAlbumList = new AlbumList();
        private readonly AlbumList _toShowAlbumList = new AlbumList();

        public SongInfo(Song cache)
        {
            _toShowSong = cache;
            InitializeComponent();
        }

        private void SongInfo_Load(object sender, EventArgs e)
        {
            name.Text = _toShowSong.Name;
            id.Text = @"Id: " + _toShowSong.Id;
            date.Value = _toShowSong.Date;

            if (File.Exists(AlbumBase))
            {
                Stream showAlbum = File.Open(AlbumBase, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                _cacheAlbumList = (AlbumList) deserializer.Deserialize(showAlbum);
                showAlbum.Close();

                foreach (Album album in _cacheAlbumList)
                {
                    foreach (Song song in album.Songs)
                    {
                        if (song.Id == _toShowSong.Id) _toShowAlbumList.AddToSecondary(album);
                    }
                }
                if (_toShowAlbumList.Count != 0)
                {
                    fromAlbumsList.DataSource = _toShowAlbumList;
                }
                else
                {
                    fromAlbumsList.Hide();
                    fromAlbum.Text = "There are no albums\nthat contain this song";
                }
            }
            else
            {
                fromAlbumsList.Hide();
                fromAlbum.Text = @"There are no albums";
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            edit.Enabled = false;
            date.Enabled = true;
            name.Enabled = true;
            submit.Enabled = true;
            _cacheName = name.Text;
            _cacheDate = date.Value;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if ((name.Text != _cacheName || date.Value != _cacheDate) && name.TextLength != 0)
            {
                int spaces = 0;
                for (int i = 0; i < name.TextLength; i++)
                {
                    if (name.Text[i] == ' ') spaces ++;
                }
                if (spaces == name.TextLength)
                {
                    MessageBox.Show(@"Enter a correct name");
                }
                else
                {
                    Stream toEdit = File.Open(SongBase, FileMode.Open);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    _toEditSongList = (SongList) deserializer.Deserialize(toEdit);
                    toEdit.Close();

                    foreach (Song song in _toEditSongList)
                    {
                        if (_toShowSong.Id == song.Id)
                        {
                            song.Name = name.Text;
                            song.Date = date.Value;
                        }
                    }

                    FileStream toFile = File.OpenWrite(SongBase);
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(toFile, _toEditSongList);
                    toFile.Close();
                }
                MessageBox.Show(@"Sucessfully edited!");
                Close();
            }
            else
            {
                MessageBox.Show(@"You did not commit any changes");
            }
        }
    }
}