namespace Library
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startingText = new System.Windows.Forms.Label();
            this.readerButton = new System.Windows.Forms.Button();
            this.librarianButton = new System.Windows.Forms.Button();
            this.headButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.whoiamPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.whoiamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startingText
            // 
            this.startingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingText.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startingText.Location = new System.Drawing.Point(0, 0);
            this.startingText.Name = "startingText";
            this.startingText.Size = new System.Drawing.Size(834, 441);
            this.startingText.TabIndex = 1;
            this.startingText.Text = "label1";
            this.startingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readerButton
            // 
            this.readerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.readerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.readerButton.FlatAppearance.BorderSize = 0;
            this.readerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readerButton.Location = new System.Drawing.Point(209, 3);
            this.readerButton.Name = "readerButton";
            this.readerButton.Size = new System.Drawing.Size(200, 50);
            this.readerButton.TabIndex = 2;
            this.readerButton.Text = "Я читач";
            this.readerButton.UseVisualStyleBackColor = false;
            this.readerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // librarianButton
            // 
            this.librarianButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.librarianButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.librarianButton.FlatAppearance.BorderSize = 0;
            this.librarianButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.librarianButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.librarianButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.librarianButton.Location = new System.Drawing.Point(3, 59);
            this.librarianButton.Name = "librarianButton";
            this.librarianButton.Size = new System.Drawing.Size(200, 50);
            this.librarianButton.TabIndex = 3;
            this.librarianButton.Text = "Я бібліотекар";
            this.librarianButton.UseVisualStyleBackColor = false;
            // 
            // headButton
            // 
            this.headButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.headButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.headButton.FlatAppearance.BorderSize = 0;
            this.headButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headButton.Location = new System.Drawing.Point(3, 3);
            this.headButton.Name = "headButton";
            this.headButton.Size = new System.Drawing.Size(200, 50);
            this.headButton.TabIndex = 4;
            this.headButton.Text = "Я завідувач";
            this.headButton.UseVisualStyleBackColor = false;
            // 
            // decButton
            // 
            this.decButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.decButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.decButton.FlatAppearance.BorderSize = 0;
            this.decButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.decButton.Location = new System.Drawing.Point(209, 59);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(200, 50);
            this.decButton.TabIndex = 5;
            this.decButton.Text = "Я декадент";
            this.decButton.UseVisualStyleBackColor = false;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // whoiamPanel
            // 
            this.whoiamPanel.Controls.Add(this.headButton);
            this.whoiamPanel.Controls.Add(this.readerButton);
            this.whoiamPanel.Controls.Add(this.librarianButton);
            this.whoiamPanel.Controls.Add(this.decButton);
            this.whoiamPanel.Location = new System.Drawing.Point(219, 202);
            this.whoiamPanel.Name = "whoiamPanel";
            this.whoiamPanel.Size = new System.Drawing.Size(412, 123);
            this.whoiamPanel.TabIndex = 6;
            this.whoiamPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.whoiamPanel);
            this.Controls.Add(this.startingText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.whoiamPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label startingText;
        private System.Windows.Forms.Button readerButton;
        private System.Windows.Forms.Button librarianButton;
        private System.Windows.Forms.Button headButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.FlowLayoutPanel whoiamPanel;
    }
}

