namespace MuBoxic.View
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
            this.Title2 = new System.Windows.Forms.TextBox();
            this.settings = new System.Windows.Forms.Button();
            this.songView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellContextMenuSong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoOrEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellContextMenuAlbum = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoOrEditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Title1 = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.artists = new System.Windows.Forms.Button();
            this.albums = new System.Windows.Forms.Button();
            this.songs = new System.Windows.Forms.Button();
            this.addSong = new System.Windows.Forms.Button();
            this.addAlbum = new System.Windows.Forms.Button();
            this.addArtist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.artistView = new System.Windows.Forms.DataGridView();
            this.cellContextMenuArtist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoOrEditToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.songView)).BeginInit();
            this.cellContextMenuSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumView)).BeginInit();
            this.cellContextMenuAlbum.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistView)).BeginInit();
            this.cellContextMenuArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // settings
            // 
            resources.ApplyResources(this.settings, "settings");
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings.Image = global::MuBoxic.Properties.Resources.information;
            this.settings.Name = "settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
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
            this.Id.ContextMenuStrip = this.cellContextMenuSong;
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // cellContextMenuSong
            // 
            this.cellContextMenuSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoOrEditToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cellContextMenuSong.Name = "cellContextMenu";
            this.cellContextMenuSong.ShowImageMargin = false;
            resources.ApplyResources(this.cellContextMenuSong, "cellContextMenuSong");
            this.cellContextMenuSong.Opening += new System.ComponentModel.CancelEventHandler(this.cellContextMenu_Opening);
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
            resources.ApplyResources(this.albumView, "albumView");
            this.albumView.AutoGenerateColumns = false;
            this.albumView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn});
            this.albumView.DataSource = this.albumListBindingSource;
            this.albumView.Name = "albumView";
            this.albumView.ReadOnly = true;
            this.albumView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumView_CellContentClick);
            this.albumView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.ContextMenuStrip = this.cellContextMenuAlbum;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cellContextMenuAlbum
            // 
            this.cellContextMenuAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoOrEditToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.cellContextMenuAlbum.Name = "cellContextMenuAlbum";
            resources.ApplyResources(this.cellContextMenuAlbum, "cellContextMenuAlbum");
            this.cellContextMenuAlbum.Opening += new System.ComponentModel.CancelEventHandler(this.cellContextMenuAlbum_Opening);
            // 
            // showInfoOrEditToolStripMenuItem1
            // 
            this.showInfoOrEditToolStripMenuItem1.Name = "showInfoOrEditToolStripMenuItem1";
            resources.ApplyResources(this.showInfoOrEditToolStripMenuItem1, "showInfoOrEditToolStripMenuItem1");
            this.showInfoOrEditToolStripMenuItem1.Click += new System.EventHandler(this.showInfoOrEditToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            resources.ApplyResources(this.deleteToolStripMenuItem1, "deleteToolStripMenuItem1");
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.searchBox.Name = "searchBox";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.SearchItem);
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
            this.Title1.Click += new System.EventHandler(this.Title1_Click);
            // 
            // refresh
            // 
            resources.ApplyResources(this.refresh, "refresh");
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.Image = global::MuBoxic.Properties.Resources.rotate;
            this.refresh.Name = "refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // artists
            // 
            this.artists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(143)))));
            this.artists.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.artists, "artists");
            this.artists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.artists.Name = "artists";
            this.artists.UseVisualStyleBackColor = false;
            this.artists.Click += new System.EventHandler(this.artists_Click);
            // 
            // albums
            // 
            this.albums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(150)))), ((int)(((byte)(177)))));
            this.albums.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.albums, "albums");
            this.albums.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.albums.Name = "albums";
            this.albums.UseVisualStyleBackColor = false;
            this.albums.Click += new System.EventHandler(this.albums_Click);
            // 
            // songs
            // 
            this.songs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(169)))), ((int)(((byte)(156)))));
            this.songs.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.songs, "songs");
            this.songs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.songs.Name = "songs";
            this.songs.UseVisualStyleBackColor = false;
            this.songs.Click += new System.EventHandler(this.songs_Click);
            // 
            // addSong
            // 
            this.addSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(169)))), ((int)(((byte)(156)))));
            this.addSong.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addSong, "addSong");
            this.addSong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addSong.Name = "addSong";
            this.addSong.UseVisualStyleBackColor = false;
            this.addSong.Click += new System.EventHandler(this.addSong_Click);
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
            // addArtist
            // 
            this.addArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(143)))));
            this.addArtist.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addArtist, "addArtist");
            this.addArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addArtist.Name = "addArtist";
            this.addArtist.UseVisualStyleBackColor = false;
            this.addArtist.Click += new System.EventHandler(this.addArtist_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = global::MuBoxic.Properties.Resources.panelbg1;
            this.panel1.Controls.Add(this.addArtist);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.addAlbum);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.addSong);
            this.panel1.Controls.Add(this.songs);
            this.panel1.Controls.Add(this.albums);
            this.panel1.Controls.Add(this.artists);
            this.panel1.Name = "panel1";
            // 
            // artistView
            // 
            this.artistView.AllowUserToAddRows = false;
            this.artistView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.artistView, "artistView");
            this.artistView.AutoGenerateColumns = false;
            this.artistView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.countryDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn1});
            this.artistView.DataSource = this.artistListBindingSource;
            this.artistView.Name = "artistView";
            this.artistView.ReadOnly = true;
            this.artistView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.artistView_CellDoubleClick);
            // 
            // cellContextMenuArtist
            // 
            this.cellContextMenuArtist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoOrEditToolStripMenuItem2,
            this.deleteToolStripMenuItem2});
            this.cellContextMenuArtist.Name = "cellContextMenuArtist";
            resources.ApplyResources(this.cellContextMenuArtist, "cellContextMenuArtist");
            this.cellContextMenuArtist.Opening += new System.ComponentModel.CancelEventHandler(this.cellContextMenuArtist_Opening);
            // 
            // showInfoOrEditToolStripMenuItem2
            // 
            this.showInfoOrEditToolStripMenuItem2.Name = "showInfoOrEditToolStripMenuItem2";
            resources.ApplyResources(this.showInfoOrEditToolStripMenuItem2, "showInfoOrEditToolStripMenuItem2");
            this.showInfoOrEditToolStripMenuItem2.Click += new System.EventHandler(this.showInfoOrEditToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            resources.ApplyResources(this.deleteToolStripMenuItem2, "deleteToolStripMenuItem2");
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuArtist;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.ContextMenuStrip = this.cellContextMenuArtist;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn2, "nameDataGridViewTextBoxColumn2");
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuArtist;
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            resources.ApplyResources(this.countryDataGridViewTextBoxColumn, "countryDataGridViewTextBoxColumn");
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.ContextMenuStrip = this.cellContextMenuArtist;
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            resources.ApplyResources(this.yearDataGridViewTextBoxColumn1, "yearDataGridViewTextBoxColumn1");
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // artistListBindingSource
            // 
            this.artistListBindingSource.DataSource = typeof(MuBoxic.ArtistList);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.ContextMenuStrip = this.cellContextMenuAlbum;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn1, "nameDataGridViewTextBoxColumn1");
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuAlbum;
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
            this.nameDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuSong;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuSong;
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
            this.BackgroundImage = global::MuBoxic.Properties.Resources.mainbg1;
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.artistView);
            this.Controls.Add(this.albumView);
            this.Controls.Add(this.songView);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.songView)).EndInit();
            this.cellContextMenuSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumView)).EndInit();
            this.cellContextMenuAlbum.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artistView)).EndInit();
            this.cellContextMenuArtist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artistListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Title2;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.DataGridView songView;
        private System.Windows.Forms.DataGridView albumView;
        private System.Windows.Forms.BindingSource songListBindingSource;
        private System.Windows.Forms.BindingSource albumListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ContextMenuStrip cellContextMenuSong;
        private System.Windows.Forms.ToolStripMenuItem showInfoOrEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox Title1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button artists;
        private System.Windows.Forms.Button albums;
        private System.Windows.Forms.Button songs;
        private System.Windows.Forms.Button addSong;
        private System.Windows.Forms.Button addAlbum;
        private System.Windows.Forms.Button addArtist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cellContextMenuAlbum;
        private System.Windows.Forms.ToolStripMenuItem showInfoOrEditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView artistView;
        private System.Windows.Forms.BindingSource artistListBindingSource;
        private System.Windows.Forms.ContextMenuStrip cellContextMenuArtist;
        private System.Windows.Forms.ToolStripMenuItem showInfoOrEditToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
    }
}

