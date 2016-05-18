using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }
    }
}
