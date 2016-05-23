using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MuBoxic
{
    public partial class addSong : Form
    {
        const string FileName = @"Database.bin";

        public addSong()
        {
            InitializeComponent();
        }
        
        private SongList cacheList = new SongList();

        private void addSong_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (File.Exists(FileName))
            {
                Stream fromFile = File.Open(FileName, FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                cacheList = (SongList)deserializer.Deserialize(fromFile);
                fromFile.Close();
            }
            else
            {
                Stream fromfile = File.Create(FileName);
                fromfile.Close();
            }
            Song cacheSong = new Song(name.Text, date.Value);
            cacheList.Add(cacheSong);
            if (File.Exists(FileName))
            {
                FileStream toFile = File.OpenWrite(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(toFile, cacheList);
                toFile.Close();
            }
            else
            {
                FileStream toFile = File.Create(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(toFile, cacheList);
                toFile.Close();
            }
        }

        private void addSong_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            foreach(Song s in cacheList)
            {
                string message = s.Name;
                DialogResult result;
                result = MessageBox.Show(message);
            }
        }
    }
}
