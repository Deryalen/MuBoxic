namespace MuBoxic.View
{
    partial class ArtistInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.albumView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.songView = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.editAlbums = new System.Windows.Forms.CheckedListBox();
            this.editSongs = new System.Windows.Forms.CheckedListBox();
            this.cellContextMenuAlbumInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellContextMenuSongInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.albumView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songView)).BeginInit();
            this.cellContextMenuAlbumInfo.SuspendLayout();
            this.cellContextMenuSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.id.Location = new System.Drawing.Point(12, 18);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(32, 21);
            this.id.TabIndex = 0;
            this.id.Text = "Id";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Enabled = false;
            this.name.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(99, 19);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(361, 28);
            this.name.TabIndex = 1;
            // 
            // country
            // 
            this.country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.country.Enabled = false;
            this.country.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(99, 53);
            this.country.Multiline = true;
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(361, 28);
            this.country.TabIndex = 2;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(16, 500);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(444, 20);
            this.date.TabIndex = 3;
            // 
            // albumView
            // 
            this.albumView.AllowUserToAddRows = false;
            this.albumView.AllowUserToDeleteRows = false;
            this.albumView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumView.AutoGenerateColumns = false;
            this.albumView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.albumView.DataSource = this.albumListBindingSource;
            this.albumView.Location = new System.Drawing.Point(16, 108);
            this.albumView.Name = "albumView";
            this.albumView.ReadOnly = true;
            this.albumView.Size = new System.Drawing.Size(444, 184);
            this.albumView.TabIndex = 4;
            this.albumView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Albums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Songs";
            // 
            // songView
            // 
            this.songView.AllowUserToAddRows = false;
            this.songView.AllowUserToDeleteRows = false;
            this.songView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songView.AutoGenerateColumns = false;
            this.songView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1});
            this.songView.DataSource = this.songListBindingSource;
            this.songView.Location = new System.Drawing.Point(16, 336);
            this.songView.Name = "songView";
            this.songView.ReadOnly = true;
            this.songView.Size = new System.Drawing.Size(444, 152);
            this.songView.TabIndex = 7;
            this.songView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songView_CellDoubleClick);
            // 
            // edit
            // 
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edit.Location = new System.Drawing.Point(16, 526);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(218, 53);
            this.edit.TabIndex = 8;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // submit
            // 
            this.submit.Enabled = false;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(266, 526);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(194, 53);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // editAlbums
            // 
            this.editAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editAlbums.FormattingEnabled = true;
            this.editAlbums.Location = new System.Drawing.Point(16, 108);
            this.editAlbums.Name = "editAlbums";
            this.editAlbums.Size = new System.Drawing.Size(444, 184);
            this.editAlbums.TabIndex = 10;
            this.editAlbums.Visible = false;
            // 
            // editSongs
            // 
            this.editSongs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSongs.FormattingEnabled = true;
            this.editSongs.Location = new System.Drawing.Point(16, 334);
            this.editSongs.Name = "editSongs";
            this.editSongs.Size = new System.Drawing.Size(444, 154);
            this.editSongs.TabIndex = 11;
            this.editSongs.Visible = false;
            // 
            // cellContextMenuAlbumInfo
            // 
            this.cellContextMenuAlbumInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem});
            this.cellContextMenuAlbumInfo.Name = "cellContextMenuAlbumInfo";
            this.cellContextMenuAlbumInfo.Size = new System.Drawing.Size(128, 26);
            this.cellContextMenuAlbumInfo.Opening += new System.ComponentModel.CancelEventHandler(this.cellContextMenuAlbumInfo_Opening);
            // 
            // showInfoToolStripMenuItem
            // 
            this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.showInfoToolStripMenuItem.Text = "Show info";
            this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
            // 
            // cellContextMenuSongInfo
            // 
            this.cellContextMenuSongInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem1});
            this.cellContextMenuSongInfo.Name = "cellContextMenuSongInfo";
            this.cellContextMenuSongInfo.Size = new System.Drawing.Size(128, 26);
            this.cellContextMenuSongInfo.Opening += new System.ComponentModel.CancelEventHandler(this.cellContextMenuSongInfo_Opening);
            // 
            // showInfoToolStripMenuItem1
            // 
            this.showInfoToolStripMenuItem1.Name = "showInfoToolStripMenuItem1";
            this.showInfoToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.showInfoToolStripMenuItem1.Text = "Show info";
            this.showInfoToolStripMenuItem1.Click += new System.EventHandler(this.showInfoToolStripMenuItem1_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.ContextMenuStrip = this.cellContextMenuSongInfo;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.ContextMenuStrip = this.cellContextMenuSongInfo;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.ContextMenuStrip = this.cellContextMenuSongInfo;
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // songListBindingSource
            // 
            this.songListBindingSource.DataSource = typeof(MuBoxic.SongList);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuAlbumInfo;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuAlbumInfo;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuAlbumInfo;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumListBindingSource
            // 
            this.albumListBindingSource.DataSource = typeof(MuBoxic.AlbumList);
            // 
            // ArtistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(472, 591);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.country);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.songView);
            this.Controls.Add(this.albumView);
            this.Controls.Add(this.editSongs);
            this.Controls.Add(this.editAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(488, 630);
            this.Name = "ArtistInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArtistInfo";
            this.Load += new System.EventHandler(this.ArtistInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songView)).EndInit();
            this.cellContextMenuAlbumInfo.ResumeLayout(false);
            this.cellContextMenuSongInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView albumView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource albumListBindingSource;
        private System.Windows.Forms.DataGridView songView;
        private System.Windows.Forms.BindingSource songListBindingSource;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckedListBox editAlbums;
        private System.Windows.Forms.CheckedListBox editSongs;
        private System.Windows.Forms.ContextMenuStrip cellContextMenuAlbumInfo;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cellContextMenuSongInfo;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
    }
}