using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic.View
{
    public partial class ArtistInfo : Form
    {
        const string ArtistBase = @"ArtistBase.bin";
        const string AlbumBase = @"AlbumBase.bin";
        const string SongBase = @"SongBase.bin";

        private string _cacheName;
        private DateTime _cacheDate;
        private string _cacheCountry;

        private SongList _toEditSongList;

        private AlbumList _toEditAlbumList;

        private SongList _allSongsList = new SongList();

        private  ArtistList _toeditArtistList = new ArtistList();

        private readonly Artist _toShowArtist;

        public ArtistInfo(Artist cache)
        {
            _toShowArtist = cache;
            InitializeComponent();
        }

        private void ArtistInfo_Load(object sender, EventArgs e)
        {
            name.Text = _toShowArtist.Name;
            country.Text = _toShowArtist.Country;
            id.Text = @"Id: " + _toShowArtist.Id;

            if (_toShowArtist.Albums != null)
            {
                foreach (Album album in _toShowArtist.Albums)
                {
                    foreach (Song song in album.Songs)
                    {
                        _allSongsList.AddToSecondary(song);
                    }
                }
            }

            if (_toShowArtist.Songs != null)
            {
                foreach (Song song in _toShowArtist.Songs)
                {
                    _allSongsList.AddToSecondary(song);
                }
            }

            songView.DataSource = _allSongsList;
            albumView.DataSource = _toShowArtist.Albums;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            edit.Enabled = false;
            date.Enabled = true;
            name.Enabled = true;
            country.Enabled = true;
            submit.Enabled = true;
            songView.Visible = false;
            albumView.Visible = false;
            editSongs.Visible = true;
            editAlbums.Visible = true;

            Stream toSongCheckList = File.Open(SongBase, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            _toEditSongList = (SongList) deserializer.Deserialize(toSongCheckList);
            toSongCheckList.Close();

            if (File.Exists(AlbumBase))
            {
                Stream toAlbumCheckList = File.Open(AlbumBase, FileMode.Open);
                _toEditAlbumList = (AlbumList) deserializer.Deserialize(toAlbumCheckList);
                toAlbumCheckList.Close();
            }

            _cacheDate = date.Value;
            _cacheName = name.Text;
            _cacheCountry = country.Text;
            editSongs.DataSource = _toEditSongList;
            editAlbums.DataSource = _toEditAlbumList;

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if ((name.Text != _cacheName
                 || date.Value != _cacheDate
                 || country.Text != _cacheCountry
                 || songView.DataSource != editSongs.CheckedItems
                 || albumView.DataSource != editAlbums.CheckedItems)
                && name.TextLength != 0)
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

                if (spacesInCountry == country.TextLength || spacesInName == name.TextLength)
                {
                    MessageBox.Show(@"Enter a correct name and country");
                }
                else
                {
                    Stream toEdit = File.Open(ArtistBase, FileMode.Open);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    _toeditArtistList = (ArtistList) deserializer.Deserialize(toEdit);
                    toEdit.Close();

                    foreach (Artist artist in _toeditArtistList)
                    {
                        if (_toShowArtist.Id == artist.Id)
                        {
                            artist.Name = name.Text;
                            artist.Date = date.Value;
                            artist.Country = country.Text;

                            if (editSongs.CheckedItems.Count != 0)
                            {
                                if (artist.Songs != null)
                                {
                                    artist.Songs.Clear();
                                    foreach (Song song in editSongs.CheckedItems)
                                    {
                                        artist.Songs.AddToSecondary(song);
                                    }
                                }
                            }

                            if (editAlbums.CheckedItems.Count != 0)
                            {
                                artist.Albums.Clear();

                                foreach (Album album in editAlbums.CheckedItems)
                                {
                                    artist.Albums.AddToSecondary(album);
                                }
                            }
                        }
                    }

                    FileStream toFile = File.OpenWrite(ArtistBase);
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(toFile, _toeditArtistList);
                    toFile.Close();
                }
                MessageBox.Show(@"Successfully edited!");
                Close();
            }
            else
            {
                MessageBox.Show(@"You did not commit any changes");
            }
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Song cache = (Song)songView.SelectedCells[0].OwningRow.DataBoundItem;
            SongInfo info = new SongInfo(cache);
            info.ShowDialog();
        }

        private void cellContextMenuSongInfo_Opening(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void cellContextMenuAlbumInfo_Opening(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Album cache = (Album)albumView.SelectedCells[0].OwningRow.DataBoundItem;
            AlbumInfo info = new AlbumInfo(cache);
            info.ShowDialog();
        }

        private void albumView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Album cache = (Album)albumView.SelectedCells[0].OwningRow.DataBoundItem;
            AlbumInfo info = new AlbumInfo(cache);
            info.ShowDialog();
        }

        private void songView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Song cache = (Song)songView.SelectedCells[0].OwningRow.DataBoundItem;
            SongInfo info = new SongInfo(cache);
            info.ShowDialog();
        }
    }
}