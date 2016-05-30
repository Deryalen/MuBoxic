using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        SongList _songCacheList = new SongList();
        AlbumList _albumCacheList = new AlbumList();
        ArtistList _artistCacheList = new ArtistList();

        const string SongBase = @"SongBase.bin";
        const string AlbumBase = @"AlbumBase.bin";
        const string ArtistBase = @"ArtistBase.bin";

        private void add_Click(object sender, EventArgs e)
        {
            AddSong song = new AddSong();
            song.Show();
        }

        private void artists_Click(object sender, EventArgs e)
        {

        }

        private void albums_Click(object sender, EventArgs e)
        {
            Stream fromFile = File.Open(AlbumBase, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            _albumCacheList = (AlbumList) deserializer.Deserialize(fromFile);
            fromFile.Close();
            songView.Hide();
            albumView.Show();
            albumView.DataSource = _albumCacheList;
        }

        private void songs_Click(object sender, EventArgs e)
        {
            Stream fromFile = File.Open(SongBase, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            _songCacheList = (SongList)deserializer.Deserialize(fromFile);
            fromFile.Close();
            albumView.Hide();
            songView.Show();
            songView.DataSource = _songCacheList;
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }

        private void addAlbum_Click(object sender, EventArgs e)
        {
            AddAlbum album = new AddAlbum();
            album.Show();
        }

        private void albumView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Album cache = (Album) albumView.SelectedCells[0].OwningRow.DataBoundItem;
            AlbumInfo info = new AlbumInfo(cache);
            info.Show();
        }
    }
}
