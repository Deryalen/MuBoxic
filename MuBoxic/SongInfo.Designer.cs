namespace MuBoxic
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(12, 38);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(297, 20);
            this.date.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(12, 15);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 13);
            this.id.TabIndex = 2;
            this.id.Text = "Id";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(73, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(236, 20);
            this.name.TabIndex = 3;
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit.Location = new System.Drawing.Point(12, 64);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(140, 25);
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
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(169, 64);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(140, 25);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // SongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 101);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button submit;
    }
}