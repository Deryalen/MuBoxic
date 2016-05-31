using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic
{
    public partial class SongInfo : Form
    {
        const string FileName = @"SongBase.bin";
        private string _cacheName;
        private DateTime _cacheDate;
        private SongList _toEditSongList = new SongList();
        private readonly Song _toShowSong;
        public SongInfo(Song cache)
        {
            _toShowSong = cache;
            InitializeComponent();
        }

        private void SongInfo_Load(object sender, EventArgs e)
        {
            name.Text = _toShowSong.Name;
            id.Text = @"Id:" + _toShowSong.Id;
            date.Value = _toShowSong.Date;
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
                    Stream toEdit = File.Open(FileName, FileMode.Open);
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

                    FileStream toFile = File.OpenWrite(FileName);
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(toFile, _toEditSongList);
                    toFile.Close();
                }
            }
            else
            {
                MessageBox.Show(@"You did not commit any changes");
            }
        }
    }
}