namespace MuBoxic.View
{
    partial class SongInfo
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.fromAlbum = new System.Windows.Forms.Label();
            this.fromAlbumsList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fromAlbumsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(12, 186);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(297, 20);
            this.date.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.id.Location = new System.Drawing.Point(9, 15);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(32, 21);
            this.id.TabIndex = 2;
            this.id.Text = "Id";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Enabled = false;
            this.name.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(84, 16);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(225, 26);
            this.name.TabIndex = 3;
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edit.Location = new System.Drawing.Point(12, 212);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(140, 50);
            this.edit.TabIndex = 4;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submit.Enabled = false;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(169, 212);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(140, 50);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // fromAlbum
            // 
            this.fromAlbum.AutoSize = true;
            this.fromAlbum.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fromAlbum.Location = new System.Drawing.Point(9, 45);
            this.fromAlbum.Name = "fromAlbum";
            this.fromAlbum.Size = new System.Drawing.Size(156, 21);
            this.fromAlbum.TabIndex = 6;
            this.fromAlbum.Text = "From albums:";
            // 
            // fromAlbumsList
            // 
            this.fromAlbumsList.AllowUserToAddRows = false;
            this.fromAlbumsList.AllowUserToDeleteRows = false;
            this.fromAlbumsList.AutoGenerateColumns = false;
            this.fromAlbumsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fromAlbumsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.fromAlbumsList.DataSource = this.albumListBindingSource;
            this.fromAlbumsList.Location = new System.Drawing.Point(12, 69);
            this.fromAlbumsList.Name = "fromAlbumsList";
            this.fromAlbumsList.ReadOnly = true;
            this.fromAlbumsList.Size = new System.Drawing.Size(297, 111);
            this.fromAlbumsList.TabIndex = 7;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumListBindingSource
            // 
            this.albumListBindingSource.DataSource = typeof(MuBoxic.AlbumList);
            // 
            // SongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(321, 274);
            this.Controls.Add(this.fromAlbumsList);
            this.Controls.Add(this.fromAlbum);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SongInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SongInfo";
            this.Load += new System.EventHandler(this.SongInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fromAlbumsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label fromAlbum;
        private System.Windows.Forms.DataGridView fromAlbumsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource albumListBindingSource;
    }
}