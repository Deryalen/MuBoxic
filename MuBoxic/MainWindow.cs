using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
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

        SongList cacheList = new SongList();
        const string FileName = @"Database.bin";

        private void add_Click(object sender, EventArgs e)
        {
            addSong add = new addSong();
            add.Show();
        }

        private void artists_Click(object sender, EventArgs e)
        {

        }

        private void albums_Click(object sender, EventArgs e)
        {

        }

        private void songs_Click(object sender, EventArgs e)
        {
            Stream fromFile = File.Open(FileName, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            cacheList = (SongList)deserializer.Deserialize(fromFile);
            fromFile.Close();
            dataGridView1.Show();
            dataGridView1.DataSource = cacheList;
            DataGridViewColumn newCol = dataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Selected) == 1 ? dataGridView1.SelectedColumns[0] : null;

            DataGridViewColumn oldCol = dataGridView1.SortedColumn;
            ListSortDirection direction;

            if(oldCol != null)
            {
                if(oldCol == newCol && dataGridView1.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldCol.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            if(newCol == null)
            {
                MessageBox.Show("Select a column", "Error: invalid selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.Sort(newCol, direction);
                newCol.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            songListBindingSource.Filter ="[Name]" + 
        }

        private void settings_Click(object sender, EventArgs e)
        {

        }
    }
}
