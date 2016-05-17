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
            this.AlbumsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Title1 = new System.Windows.Forms.TextBox();
            this.Title2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlbumsButton
            // 
            this.AlbumsButton.BackColor = System.Drawing.Color.Purple;
            this.AlbumsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlbumsButton.FlatAppearance.BorderSize = 0;
            this.AlbumsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumsButton.Font = new System.Drawing.Font("AR CARTER", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsButton.Location = new System.Drawing.Point(0, 210);
            this.AlbumsButton.Margin = new System.Windows.Forms.Padding(0);
            this.AlbumsButton.Name = "AlbumsButton";
            this.AlbumsButton.Size = new System.Drawing.Size(138, 70);
            this.AlbumsButton.TabIndex = 3;
            this.AlbumsButton.Text = "Albums";
            this.AlbumsButton.UseVisualStyleBackColor = false;
            this.AlbumsButton.Click += new System.EventHandler(this.AlbumsButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("AR CARTER", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Artists";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orchid;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("AR CARTER", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "Songs";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Plum;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("AR CARTER", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.HotPink;
            this.Title1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.Font = new System.Drawing.Font("Magneto", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.Color.Black;
            this.Title1.Location = new System.Drawing.Point(0, 0);
            this.Title1.Margin = new System.Windows.Forms.Padding(0);
            this.Title1.Multiline = true;
            this.Title1.Name = "Title1";
            this.Title1.ReadOnly = true;
            this.Title1.Size = new System.Drawing.Size(804, 70);
            this.Title1.TabIndex = 0;
            this.Title1.TabStop = false;
            this.Title1.Text = "New Retro";
            // 
            // Title2
            // 
            this.Title2.BackColor = System.Drawing.Color.HotPink;
            this.Title2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title2.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.ForeColor = System.Drawing.Color.Black;
            this.Title2.Location = new System.Drawing.Point(0, 70);
            this.Title2.Margin = new System.Windows.Forms.Padding(0);
            this.Title2.Multiline = true;
            this.Title2.Name = "Title2";
            this.Title2.ReadOnly = true;
            this.Title2.Size = new System.Drawing.Size(804, 42);
            this.Title2.TabIndex = 1;
            this.Title2.TabStop = false;
            this.Title2.Text = "                                        Base";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AlbumsButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 280);
            this.panel1.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AlbumsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Title1;
        private System.Windows.Forms.TextBox Title2;
        private System.Windows.Forms.Panel panel1;
    }
}

