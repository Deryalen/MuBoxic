using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic.View
{
    public partial class AlbumInfo : Form
    {
        const string AlbumBase = @"AlbumBase.bin";

        const string SongBase = @"SongBase.bin";

        private DateTime _cacheDate;
        private string _cacheName;

        private SongList _toEditSongList;

        private AlbumList _toEditAlbumList = new AlbumList();

        private readonly Album _toShowAlbum;

        public AlbumInfo(Album cache)
        {
            _toShowAlbum = cache;
            InitializeComponent();
        }

        private void AlbumInfo_Load(object sender, EventArgs e)
        {
            name.Text = _toShowAlbum.Name;
            date.Value = _toShowAlbum.Date;
            id.Text = @"Id: " + _toShowAlbum.Id;
            songs.DataSource = _toShowAlbum.Songs;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            edit.Enabled = false;
            date.Enabled = true;
            name.Enabled = true;
            submit.Enabled = true;
            songs.Visible = false;
            editSongs.Visible = true;
            
            Stream toCheckList = File.Open(SongBase, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            _toEditSongList = (SongList)deserializer.Deserialize(toCheckList);
            toCheckList.Close();

            _cacheDate = date.Value;
            _cacheName = name.Text;
            editSongs.DataSource = _toEditSongList;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if ((name.Text != _cacheName || date.Value != _cacheDate || songs.DataSource != editSongs.CheckedItems) &&
                name.TextLength != 0)
            {
                int spaces = 0;
                for (int i = 0; i < name.TextLength; i++)
                {
                    if (name.Text[i] == ' ') spaces++;
                }
                if (spaces == name.TextLength)
                {
                    MessageBox.Show(@"Enter a correct name");
                }
                else
                {
                    Stream toEdit = File.Open(AlbumBase, FileMode.Open);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    _toEditAlbumList = (AlbumList) deserializer.Deserialize(toEdit);
                    toEdit.Close();

                    foreach (Album album in _toEditAlbumList)
                    {
                        if (_toShowAlbum.Id == album.Id)
                        {
                            album.Name = name.Text;
                            album.Date = date.Value;
                            if (editSongs.CheckedItems.Count != 0)
                            {
                                album.Songs.Clear();

                                foreach (Song song in editSongs.CheckedItems)
                                {
                                    album.Songs.AddToSecondary(song);
                                }
                            }
                        }
                    }

                    FileStream toFile = File.OpenWrite(AlbumBase);
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(toFile, _toEditAlbumList);
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

        private void showInfoOrEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Song cache = (Song)songs.SelectedCells[0].OwningRow.DataBoundItem;
            SongInfo info = new SongInfo(cache);
            info.ShowDialog();
        }

        private void cellContextMenuAlbumInfo_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var selected = songs.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo selectedCell = songs.HitTest(selected.X, selected.Y);
            if (selectedCell.Type == DataGridViewHitTestType.Cell)
            {
                songs.ClearSelection();
                songs[selectedCell.ColumnIndex, selectedCell.RowIndex].Selected = true;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}