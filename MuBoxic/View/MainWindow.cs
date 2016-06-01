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

        SongList _songCacheList = new SongList();
        AlbumList _albumCacheList = new AlbumList();
        ArtistList _artistCacheList = new ArtistList();

        const string SongBase = @"SongBase.bin";
        const string AlbumBase = @"AlbumBase.bin";
        const string ArtistBase = @"ArtistBase.bin";

        private void addSong_Click(object sender, EventArgs e)
        {
            AddSong song = new AddSong();
            song.ShowDialog();
        }

        private void artists_Click(object sender, EventArgs e)
        {
            if (File.Exists(ArtistBase))
            {
                Stream artistFromFile = File.Open(ArtistBase, FileMode.Open);
                BinaryFormatter artistDeserializer = new BinaryFormatter();
                _artistCacheList = (ArtistList) artistDeserializer.Deserialize(artistFromFile);
                artistFromFile.Close();
                if (_artistCacheList.Count != 0)
                {
                    songView.Hide();
                    albumView.Hide();
                    artistView.Show();
                    artistView.DataSource = _artistCacheList;
                }
                else
                {
                    MessageBox.Show(@"There are no artists. Add some!");
                }
            }
            else
            {
                MessageBox.Show(@"There are no artists. Add some!");
            }
        }

        private void albums_Click(object sender, EventArgs e)
        {
            if (File.Exists(AlbumBase))
            {
                Stream albumFroFile = File.Open(AlbumBase, FileMode.Open);
                BinaryFormatter albumDeserializer = new BinaryFormatter();
                _albumCacheList = (AlbumList) albumDeserializer.Deserialize(albumFroFile);
                albumFroFile.Close();
                if (_albumCacheList.Count != 0)
                {
                    songView.Hide();
                    artistView.Hide();
                    albumView.Show();
                    albumView.DataSource = _albumCacheList;
                }
                else
                {
                    MessageBox.Show(@"There are no albums. Add some!");
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
                    artistView.Hide();
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
            InfoForm info = new InfoForm();
            info.Show();
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
            if (File.Exists(ArtistBase))
            {
                Stream artistStream = File.Open(ArtistBase, FileMode.Open);
                BinaryFormatter deserializerArtists = new BinaryFormatter();
                _artistCacheList = (ArtistList) deserializerArtists.Deserialize(artistStream);
                artistStream.Close();
                artistView.DataSource = _artistCacheList;
            }
        }

        private void SearchItem(object sender, EventArgs e)
        {
            string query = searchBox.Text;
            if (query == "")
            {
                songView.DataSource = _songCacheList;
                albumView.DataSource = _albumCacheList;
                artistView.DataSource = _artistCacheList;
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
            else if (artistView.Visible)
            {
                ArtistList searchResult = new ArtistList();
                foreach (Artist artist in _artistCacheList)
                {
                    if (artist.Name.ToLower().IndexOf(query, StringComparison.Ordinal) != -1
                        || artist.Country.ToLower().IndexOf(query, StringComparison.Ordinal) != -1
                        || Convert.ToString(artist.Id).IndexOf(query, StringComparison.Ordinal) != -1
                        || Convert.ToString(artist.Date, CultureInfo.CurrentCulture)
                        .IndexOf(query, StringComparison.Ordinal) != -1)
                        searchResult.AddToSecondary(artist);
                }
                artistView.DataSource = searchResult;
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

        private void cellContextMenuAlbum_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var selected = albumView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo selectedCell = albumView.HitTest(selected.X, selected.Y);
            if (selectedCell.Type == DataGridViewHitTestType.Cell)
            {
                albumView.ClearSelection();
                albumView[selectedCell.ColumnIndex, selectedCell.RowIndex].Selected = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void addArtist_Click(object sender, EventArgs e)
        {
            AddArtist artist = new AddArtist();
            artist.ShowDialog();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Album cache = (Album)albumView.SelectedCells[0].OwningRow.DataBoundItem;

            Stream toDelete = File.Open(AlbumBase, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            _albumCacheList = (AlbumList)deserializer.Deserialize(toDelete);
            toDelete.Close();

            foreach (Album album in _albumCacheList)
            {
                if (album.Id == cache.Id)
                {
                    _albumCacheList.Remove(album);
                    break;
                }
            }

            FileStream toFile = File.Create(AlbumBase);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(toFile, _albumCacheList);
            toFile.Close();

            if (_albumCacheList.Count != 0)
            {
                albumView.Refresh();
                albumView.DataSource = _albumCacheList;
            }
            else
            {
                albumView.Hide();
            }

            MessageBox.Show(@"Sucessfully deleted!");
        }

        private void artistView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Artist cache = (Artist)artistView.SelectedCells[0].OwningRow.DataBoundItem;
            ArtistInfo info = new ArtistInfo(cache);
            info.ShowDialog();
        }

        private void cellContextMenuArtist_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var selected = artistView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo selectedCell = artistView.HitTest(selected.X, selected.Y);
            if (selectedCell.Type == DataGridViewHitTestType.Cell)
            {
                artistView.ClearSelection();
                artistView[selectedCell.ColumnIndex, selectedCell.RowIndex].Selected = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void showInfoOrEditToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Artist cache = (Artist)artistView.SelectedCells[0].OwningRow.DataBoundItem;
            ArtistInfo info = new ArtistInfo(cache);
            info.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Artist cache = (Artist)artistView.SelectedCells[0].OwningRow.DataBoundItem;

            Stream toDelete = File.Open(ArtistBase, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            _artistCacheList = (ArtistList)deserializer.Deserialize(toDelete);
            toDelete.Close();

            foreach (Artist artist in _artistCacheList)
            {
                if (artist.Id == cache.Id)
                {
                    _artistCacheList.Remove(artist);
                    break;
                }
            }

            FileStream toFile = File.Create(ArtistBase);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(toFile, _artistCacheList);
            toFile.Close();

            if (_artistCacheList.Count != 0)
            {
                artistView.Refresh();
                artistView.DataSource = _artistCacheList;
            }
            else
            {
                artistView.Hide();
            }

            MessageBox.Show(@"Sucessfully deleted!");
        }
    }
}