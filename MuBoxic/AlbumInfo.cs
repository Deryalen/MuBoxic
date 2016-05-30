using System;
using System.Windows.Forms;

namespace MuBoxic
{
    public partial class AlbumInfo : Form
    {
        private Album toShow;
        public AlbumInfo(Album cache)
        {
            toShow = cache;
            InitializeComponent();
        }

        private void AlbumInfo_Load(object sender, EventArgs e)
        {
            name.Text = toShow.Name;
            date.Value = toShow.Date;
            id.Text = @"#" + toShow.Id;
            songs.DataSource = toShow.Songs;
        }
    }
}