using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic.View
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

        private void addSong_Slick(object sender, EventArgs e)
        {
            AddSong song = new AddSong();
            song.ShowDialog();
        }

        private void artists_Click(object sender, EventArgs e)
        {

        }

        private void albums_Click(object sender, EventArgs e)
        {
            if (File.Exists(AlbumBase))
            {
                Stream fromFile = File.Open(AlbumBase, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                _albumCacheList = (AlbumList) deserializer.Deserialize(fromFile);
                fromFile.Close();
                if (_albumCacheList.Count != 0)
                {
                    songView.Hide();
                    albumView.Show();
                    albumView.DataSource = _albumCacheList;
                }
                else
                {
                    MessageBox.Show(@"There are no albums. Add some!");
                    albumView.Hide();
                }
            }
            else
            {
                MessageBox.Show(@"There are no albums. Add some!");
            }
        }

        private void songs_Click(object sender, EventArgs e)
        {
            songView.BackgroundImage = Image.FromFile(@"..\..\images\mainbg1.png");
            if (File.Exists(SongBase))
            {
                Stream fromFile = File.Open(SongBase, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                _songCacheList = (SongList) deserializer.Deserialize(fromFile);
                fromFile.Close();
                if (_songCacheList.Count != 0)
                {
                    albumView.Hide();
                    songView.Show();
                    songView.DataSource = _songCacheList;
                }
                else
                {
                    MessageBox.Show(@"There are no songs. Add some!");
                    songView.Hide();
                }
            }
            else
            {
                MessageBox.Show(@"There are no songs. Add some!");
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {

        }

        private void addAlbum_Click(object sender, EventArgs e)
        {
            AddAlbum album = new AddAlbum();
            album.ShowDialog();
        }

        private void albumView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                Album cache = (Album) albumView.SelectedCells[0].OwningRow.DataBoundItem;
                AlbumInfo info = new AlbumInfo(cache);
                info.ShowDialog();
        }

        private void songView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Song cache = (Song) songView.SelectedCells[0].OwningRow.DataBoundItem;
            SongInfo info = new SongInfo(cache);
            info.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Song cache = (Song) songView.SelectedCells[0].OwningRow.DataBoundItem;
            
            Stream toDelete = File.Open(SongBase, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            _songCacheList = (SongList) deserializer.Deserialize(toDelete);
            toDelete.Close();

            foreach (Song song in _songCacheList)
            {
                if (song.Id == cache.Id)
                {
                    _songCacheList.Remove(song);
                    break;
                }
            }

            FileStream toFile = File.Create(SongBase);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(toFile, _songCacheList);
            toFile.Close();

            if (_songCacheList.Count != 0)
            {
                songView.Refresh();
                songView.DataSource = _songCacheList;
            }
            else
            {
                songView.Hide();
            }

            MessageBox.Show(@"Sucessfully deleted!");
        }

        private void showInfoOrEditToolStripMenuItem_Click(object sender, MouseEventArgs e)
        {
            Song cache = (Song) songView.SelectedCells[0].OwningRow.DataBoundItem;
            SongInfo info = new SongInfo(cache);
            info.ShowDialog();
        }

        private void cellContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var selected = songView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo selectedCell = songView.HitTest(selected.X, selected.Y);
            if (selectedCell.Type == DataGridViewHitTestType.Cell)
            {
                songView.ClearSelection();
                songView[selectedCell.ColumnIndex, selectedCell.RowIndex].Selected = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (File.Exists(SongBase))
            {
                Stream songsStream = File.Open(SongBase, FileMode.Open);
                BinaryFormatter deserializerSongs = new BinaryFormatter();
                _songCacheList = (SongList) deserializerSongs.Deserialize(songsStream);
                songsStream.Close();
                songView.DataSource = _songCacheList;
            }
            if (File.Exists(AlbumBase))
            {
                Stream albumsStream = File.Open(AlbumBase, FileMode.Open);
                BinaryFormatter deserializerAlbums = new BinaryFormatter();
                _albumCacheList = (AlbumList) deserializerAlbums.Deserialize(albumsStream);
                albumsStream.Close();
                albumView.DataSource = _albumCacheList;
            }
        }

        private void SearchItem(object sender, EventArgs e)
        {
            string query = searchBox.Text;
            if (query == "")
            {
                songView.DataSource = _songCacheList;
                albumView.DataSource = _albumCacheList;
            }
            else if (songView.Visible)
            {
                SongList searchResult = new SongList();
                foreach (Song song in _songCacheList)
                {
                    if (song.Name.ToLower().IndexOf(query, StringComparison.Ordinal) != -1
                        || Convert.ToString(song.Id).IndexOf(query, StringComparison.Ordinal) != -1
                        || Convert.ToString(song.Date, CultureInfo.CurrentCulture)
                        .IndexOf(query, StringComparison.Ordinal) != -1)
                        searchResult.AddToSecondary(song);
                }
                songView.DataSource = searchResult;
            }
            else if (albumView.Visible)
            {
                AlbumList searchResult = new AlbumList();
                foreach (Album album in _albumCacheList)
                {
                    if (album.Name.ToLower().IndexOf(query, StringComparison.Ordinal) != -1 
                        || Convert.ToString(album.Id).IndexOf(query, StringComparison.Ordinal) != -1
                        || Convert.ToString(album.Date, CultureInfo.CurrentCulture)
                        .IndexOf(query, StringComparison.Ordinal) != -1)
                        searchResult.AddToSecondary(album);
                }
                albumView.DataSource = searchResult;
            }
        }

        private void albumView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void Title1_Click(object sender, EventArgs e)
        {
            searchBox.Text = @"Search...";
        }

        private void showInfoOrEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Album cache = (Album)albumView.SelectedCells[0].OwningRow.DataBoundItem;
            AlbumInfo info = new AlbumInfo(cache);
            info.ShowDialog();
        }
    }
}