namespace MuBoxic
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.albums = new System.Windows.Forms.Button();
            this.artists = new System.Windows.Forms.Button();
            this.songs = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.Title1 = new System.Windows.Forms.TextBox();
            this.Title2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addArtist = new System.Windows.Forms.Button();
            this.addAlbum = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Button();
            this.addSong = new System.Windows.Forms.Button();
            this.songView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoOrEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh = new System.Windows.Forms.Button();
            this.searchAlbums = new System.Windows.Forms.Button();
            this.searchArtists = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songView)).BeginInit();
            this.cellContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // albums
            // 
            this.albums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(150)))), ((int)(((byte)(177)))));
            resources.ApplyResources(this.albums, "albums");
            this.albums.FlatAppearance.BorderSize = 0;
            this.albums.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.albums.Name = "albums";
            this.albums.UseVisualStyleBackColor = false;
            this.albums.Click += new System.EventHandler(this.albums_Click);
            // 
            // artists
            // 
            this.artists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(143)))));
            resources.ApplyResources(this.artists, "artists");
            this.artists.FlatAppearance.BorderSize = 0;
            this.artists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.artists.Name = "artists";
            this.artists.UseVisualStyleBackColor = false;
            this.artists.Click += new System.EventHandler(this.artists_Click);
            // 
            // songs
            // 
            this.songs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(169)))), ((int)(((byte)(156)))));
            resources.ApplyResources(this.songs, "songs");
            this.songs.FlatAppearance.BorderSize = 0;
            this.songs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.songs.Name = "songs";
            this.songs.UseVisualStyleBackColor = false;
            this.songs.Click += new System.EventHandler(this.songs_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.search, "search");
            this.search.FlatAppearance.BorderSize = 0;
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Name = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.Title1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Title1, "Title1");
            this.Title1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title1.Name = "Title1";
            this.Title1.ReadOnly = true;
            this.Title1.TabStop = false;
            // 
            // Title2
            // 
            this.Title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.Title2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Title2, "Title2");
            this.Title2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title2.Name = "Title2";
            this.Title2.ReadOnly = true;
            this.Title2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchArtists);
            this.panel1.Controls.Add(this.searchAlbums);
            this.panel1.Controls.Add(this.addArtist);
            this.panel1.Controls.Add(this.addAlbum);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addSong);
            this.panel1.Controls.Add(this.songs);
            this.panel1.Controls.Add(this.albums);
            this.panel1.Controls.Add(this.artists);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // addArtist
            // 
            this.addArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(143)))));
            this.addArtist.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addArtist, "addArtist");
            this.addArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addArtist.Name = "addArtist";
            this.addArtist.UseVisualStyleBackColor = false;
            // 
            // addAlbum
            // 
            this.addAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(150)))), ((int)(((byte)(177)))));
            this.addAlbum.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addAlbum, "addAlbum");
            this.addAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAlbum.Name = "addAlbum";
            this.addAlbum.UseVisualStyleBackColor = false;
            this.addAlbum.Click += new System.EventHandler(this.addAlbum_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.settings);
            this.panel2.Controls.Add(this.search);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.settings, "settings");
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings.Name = "settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // addSong
            // 
            this.addSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(169)))), ((int)(((byte)(156)))));
            this.addSong.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addSong, "addSong");
            this.addSong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addSong.Name = "addSong";
            this.addSong.UseVisualStyleBackColor = false;
            this.addSong.Click += new System.EventHandler(this.add_Click);
            // 
            // songView
            // 
            this.songView.AllowUserToAddRows = false;
            this.songView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.songView, "songView");
            this.songView.AutoGenerateColumns = false;
            this.songView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.songView.DataSource = this.songListBindingSource;
            this.songView.Name = "songView";
            this.songView.ReadOnly = true;
            this.songView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.ContextMenuStrip = this.cellContextMenu;
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // cellContextMenu
            // 
            this.cellContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoOrEditToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cellContextMenu.Name = "cellContextMenu";
            this.cellContextMenu.ShowImageMargin = false;
            resources.ApplyResources(this.cellContextMenu, "cellContextMenu");
            this.cellContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cellContextMenu_Opening);
            // 
            // showInfoOrEditToolStripMenuItem
            // 
            this.showInfoOrEditToolStripMenuItem.Name = "showInfoOrEditToolStripMenuItem";
            resources.ApplyResources(this.showInfoOrEditToolStripMenuItem, "showInfoOrEditToolStripMenuItem");
            this.showInfoOrEditToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showInfoOrEditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // albumView
            // 
            this.albumView.AllowUserToAddRows = false;
            this.albumView.AllowUserToDeleteRows = false;
            this.albumView.AllowUserToResizeColumns = false;
            this.albumView.AllowUserToResizeRows = false;
            this.albumView.AutoGenerateColumns = false;
            this.albumView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn});
            this.albumView.DataSource = this.albumListBindingSource;
            resources.ApplyResources(this.albumView, "albumView");
            this.albumView.Name = "albumView";
            this.albumView.ReadOnly = true;
            this.albumView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // refresh
            // 
            resources.ApplyResources(this.refresh, "refresh");
            this.refresh.Name = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // searchAlbums
            // 
            resources.ApplyResources(this.searchAlbums, "searchAlbums");
            this.searchAlbums.Name = "searchAlbums";
            this.searchAlbums.UseVisualStyleBackColor = true;
            // 
            // searchArtists
            // 
            resources.ApplyResources(this.searchArtists, "searchArtists");
            this.searchArtists.Name = "searchArtists";
            this.searchArtists.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
            this.searchBox.TextChanged += new System.EventHandler(this.SearchItem);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn1, "nameDataGridViewTextBoxColumn1");
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Date";
            resources.ApplyResources(this.yearDataGridViewTextBoxColumn, "yearDataGridViewTextBoxColumn");
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumListBindingSource
            // 
            this.albumListBindingSource.DataSource = typeof(MuBoxic.AlbumList);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenu;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenu;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            resources.ApplyResources(this.dateDataGridViewTextBoxColumn, "dateDataGridViewTextBoxColumn");
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // songListBindingSource
            // 
            this.songListBindingSource.DataSource = typeof(MuBoxic.SongList);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.albumView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.songView);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songView)).EndInit();
            this.cellContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button albums;
        private System.Windows.Forms.Button artists;
        private System.Windows.Forms.Button songs;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox Title1;
        private System.Windows.Forms.TextBox Title2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button addSong;
        private System.Windows.Forms.DataGridView songView;
        private System.Windows.Forms.Button addArtist;
        private System.Windows.Forms.Button addAlbum;
        private System.Windows.Forms.DataGridView albumView;
        private System.Windows.Forms.BindingSource songListBindingSource;
        private System.Windows.Forms.BindingSource albumListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ContextMenuStrip cellContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showInfoOrEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button searchArtists;
        private System.Windows.Forms.Button searchAlbums;
        private System.Windows.Forms.TextBox searchBox;
    }
}

