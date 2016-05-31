namespace MuBoxic
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
            this.name = new System.Windows.Forms.Label();
            this.songs = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.Label();
            this.songListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.songs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(34, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // songs
            // 
            this.songs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songs.AutoGenerateColumns = false;
            this.songs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.songs.DataSource = this.songListBindingSource;
            this.songs.Location = new System.Drawing.Point(12, 68);
            this.songs.Name = "songs";
            this.songs.Size = new System.Drawing.Size(343, 181);
            this.songs.TabIndex = 1;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Location = new System.Drawing.Point(12, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(343, 20);
            this.date.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(12, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 13);
            this.id.TabIndex = 3;
            this.id.Text = "Id";
            // 
            // songListBindingSource
            // 
            this.songListBindingSource.DataSource = typeof(MuBoxic.SongList);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // AlbumInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 261);
            this.Controls.Add(this.id);
            this.Controls.Add(this.date);
            this.Controls.Add(this.songs);
            this.Controls.Add(this.name);
            this.Name = "AlbumInfo";
            this.Text = "AlbumInfo";
            this.Load += new System.EventHandler(this.AlbumInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView songs;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.BindingSource songListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}