using System;
using System.Windows.Forms;

namespace MuBoxic
{
    public partial class AlbumInfo : Form
    {
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
            id.Text = @"#" + _toShowAlbum.Id;
            songs.DataSource = _toShowAlbum.Songs;
        }
    }
}