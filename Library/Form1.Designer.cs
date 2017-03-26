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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginPassTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.regLabel = new System.Windows.Forms.Label();
            this.regTextBox = new System.Windows.Forms.TextBox();
            this.regPassTextBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.authPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.whoiamPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.authPanel.SuspendLayout();
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
            this.startingText.Size = new System.Drawing.Size(838, 468);
            this.startingText.TabIndex = 1;
            this.startingText.Text = "label1";
            this.startingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readerButton
            // 
            this.readerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.readerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.readerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.readerButton.FlatAppearance.BorderSize = 0;
            this.readerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readerButton.Location = new System.Drawing.Point(251, 46);
            this.readerButton.Name = "readerButton";
            this.readerButton.Size = new System.Drawing.Size(200, 50);
            this.readerButton.TabIndex = 2;
            this.readerButton.Text = "Я читач";
            this.readerButton.UseVisualStyleBackColor = false;
            this.readerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // librarianButton
            // 
            this.librarianButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.librarianButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.librarianButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.librarianButton.FlatAppearance.BorderSize = 0;
            this.librarianButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.librarianButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.librarianButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.librarianButton.Location = new System.Drawing.Point(45, 102);
            this.librarianButton.Name = "librarianButton";
            this.librarianButton.Size = new System.Drawing.Size(200, 50);
            this.librarianButton.TabIndex = 3;
            this.librarianButton.Text = "Я бібліотекар";
            this.librarianButton.UseVisualStyleBackColor = false;
            // 
            // headButton
            // 
            this.headButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.headButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.headButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.headButton.FlatAppearance.BorderSize = 0;
            this.headButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headButton.Location = new System.Drawing.Point(45, 46);
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
            this.decButton.Location = new System.Drawing.Point(251, 102);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(200, 50);
            this.decButton.TabIndex = 5;
            this.decButton.Text = "Я декадент";
            this.decButton.UseVisualStyleBackColor = false;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.loginLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginPassTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.loginButton, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 189);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginLabel.Location = new System.Drawing.Point(93, 10);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(56, 26);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Вхід";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(51, 56);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(140, 29);
            this.loginTextBox.TabIndex = 1;
            // 
            // loginPassTextBox
            // 
            this.loginPassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPassTextBox.Location = new System.Drawing.Point(51, 103);
            this.loginPassTextBox.Name = "loginPassTextBox";
            this.loginPassTextBox.Size = new System.Drawing.Size(140, 29);
            this.loginPassTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginButton.Location = new System.Drawing.Point(71, 150);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Увійти";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.regLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.regTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.regPassTextBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.regButton, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(251, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 189);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // regLabel
            // 
            this.regLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.regLabel.Location = new System.Drawing.Point(58, 10);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(125, 26);
            this.regLabel.TabIndex = 0;
            this.regLabel.Text = "Реєстрація";
            // 
            // regTextBox
            // 
            this.regTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regTextBox.Location = new System.Drawing.Point(51, 56);
            this.regTextBox.Name = "regTextBox";
            this.regTextBox.Size = new System.Drawing.Size(140, 29);
            this.regTextBox.TabIndex = 1;
            // 
            // regPassTextBox
            // 
            this.regPassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPassTextBox.Location = new System.Drawing.Point(51, 103);
            this.regPassTextBox.Name = "regPassTextBox";
            this.regPassTextBox.Size = new System.Drawing.Size(140, 29);
            this.regPassTextBox.TabIndex = 2;
            // 
            // regButton
            // 
            this.regButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.regButton.FlatAppearance.BorderSize = 0;
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.regButton.Location = new System.Drawing.Point(71, 150);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(100, 30);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Зареєструв.";
            this.regButton.UseVisualStyleBackColor = true;
            // 
            // authPanel
            // 
            this.authPanel.Controls.Add(this.tableLayoutPanel1);
            this.authPanel.Controls.Add(this.tableLayoutPanel2);
            this.authPanel.Location = new System.Drawing.Point(173, 142);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(496, 208);
            this.authPanel.TabIndex = 9;
            this.authPanel.Visible = false;
            // 
            // whoiamPanel
            // 
            this.whoiamPanel.ColumnCount = 2;
            this.whoiamPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.whoiamPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.whoiamPanel.Controls.Add(this.headButton, 0, 0);
            this.whoiamPanel.Controls.Add(this.readerButton, 1, 0);
            this.whoiamPanel.Controls.Add(this.decButton, 1, 1);
            this.whoiamPanel.Controls.Add(this.librarianButton, 0, 1);
            this.whoiamPanel.Location = new System.Drawing.Point(173, 145);
            this.whoiamPanel.Name = "whoiamPanel";
            this.whoiamPanel.RowCount = 2;
            this.whoiamPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.whoiamPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.whoiamPanel.Size = new System.Drawing.Size(496, 199);
            this.whoiamPanel.TabIndex = 10;
            this.whoiamPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(838, 468);
            this.Controls.Add(this.whoiamPanel);
            this.Controls.Add(this.authPanel);
            this.Controls.Add(this.startingText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.authPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox loginPassTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.TextBox regTextBox;
        private System.Windows.Forms.TextBox regPassTextBox;
        private System.Windows.Forms.FlowLayoutPanel authPanel;
        private System.Windows.Forms.TableLayoutPanel whoiamPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button regButton;
    }
}

