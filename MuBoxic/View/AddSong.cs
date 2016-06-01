using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MuBoxic.View
{
    public partial class AddSong : Form
    {
        const string FileName = @"SongBase.bin";

        public AddSong()
        {
            InitializeComponent();
        }
        
        private SongList _cacheList = new SongList();

        private void submit_Click(object sender, EventArgs e)
        {
            if (File.Exists(FileName))
            {
                Stream fromFile = File.Open(FileName, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                _cacheList = (SongList)deserializer.Deserialize(fromFile);
                fromFile.Close();
            }
            else
            {
                Stream create = File.Create(FileName);
                create.Close();
            }

            if (name.Text.Length != 0)
            {
                int spaces = 0;
                for (int i = 0; i < name.TextLength; i++)
                {
                    if (name.Text[i] == ' ')
                    {
                        spaces++;
                    }
                }
                if (spaces != name.TextLength)
                {
                    Song cacheSong = new Song(name.Text, date.Value.Date);
                    _cacheList.Add(cacheSong);
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
                MessageBox.Show(@"Enter the name of the song");
            }

            if (File.Exists(FileName))
            {
                FileStream toFile = File.OpenWrite(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(toFile, _cacheList);
                toFile.Close();
            }
            else
            {
                FileStream toFile = File.Create(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(toFile, _cacheList);
                toFile.Close();
            }
        }
    }
}
