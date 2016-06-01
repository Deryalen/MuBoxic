namespace MuBoxic.View
{
    partial class AlbumInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumInfo));
            this.songs = new System.Windows.Forms.DataGridView();
            this.cellContextMenuSongInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoOrEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.editSongs = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.songs)).BeginInit();
            this.cellContextMenuSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // songs
            // 
            this.songs.AllowUserToAddRows = false;
            this.songs.AllowUserToDeleteRows = false;
            this.songs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songs.AutoGenerateColumns = false;
            this.songs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.songs.DataSource = this.songListBindingSource;
            this.songs.Location = new System.Drawing.Point(12, 98);
            this.songs.Name = "songs";
            this.songs.ReadOnly = true;
            this.songs.Size = new System.Drawing.Size(537, 151);
            this.songs.TabIndex = 1;
            this.songs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showInfoOrEditToolStripMenuItem_Click);
            // 
            // cellContextMenuSongInfo
            // 
            this.cellContextMenuSongInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoOrEditToolStripMenuItem});
            this.cellContextMenuSongInfo.Name = "contextMenuStrip1";
            this.cellContextMenuSongInfo.Size = new System.Drawing.Size(128, 26);
            this.cellContextMenuSongInfo.Opening += new System.ComponentModel.CancelEventHandler(this.cellContextMenuAlbumInfo_Opening);
            // 
            // showInfoOrEditToolStripMenuItem
            // 
            this.showInfoOrEditToolStripMenuItem.Name = "showInfoOrEditToolStripMenuItem";
            this.showInfoOrEditToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.showInfoOrEditToolStripMenuItem.Text = "Show info";
            this.showInfoOrEditToolStripMenuItem.Click += new System.EventHandler(this.showInfoOrEditToolStripMenuItem_Click);
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(12, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(537, 20);
            this.date.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.id.Location = new System.Drawing.Point(12, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(32, 21);
            this.id.TabIndex = 3;
            this.id.Text = "Id";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Enabled = false;
            this.name.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(94, 9);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(259, 27);
            this.name.TabIndex = 4;
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edit.Location = new System.Drawing.Point(359, 9);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 27);
            this.edit.TabIndex = 5;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.Enabled = false;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(440, 9);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(109, 27);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // editSongs
            // 
            this.editSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSongs.FormattingEnabled = true;
            this.editSongs.Location = new System.Drawing.Point(12, 98);
            this.editSongs.Name = "editSongs";
            this.editSongs.Size = new System.Drawing.Size(537, 154);
            this.editSongs.TabIndex = 7;
            this.editSongs.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Songs";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuSongInfo;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuSongInfo;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.ContextMenuStrip = this.cellContextMenuSongInfo;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // songListBindingSource
            // 
            this.songListBindingSource.DataSource = typeof(MuBoxic.SongList);
            // 
            // AlbumInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(561, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.date);
            this.Controls.Add(this.songs);
            this.Controls.Add(this.editSongs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(577, 300);
            this.Name = "AlbumInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumInfo";
            this.Load += new System.EventHandler(this.AlbumInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songs)).EndInit();
            this.cellContextMenuSongInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView songs;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.BindingSource songListBindingSource;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckedListBox editSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cellContextMenuSongInfo;
        private System.Windows.Forms.ToolStripMenuItem showInfoOrEditToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}