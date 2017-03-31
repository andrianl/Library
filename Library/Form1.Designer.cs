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
            this.authPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.whoiamPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LibrarianPanel = new System.Windows.Forms.Panel();
            this.RegLibPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.regLibTextBox = new System.Windows.Forms.TextBox();
            this.passLibTextBox = new System.Windows.Forms.TextBox();
            this.RegLibButton = new System.Windows.Forms.Button();
            this.libSearch1 = new Library.LibSearch();
            this.libAccountence1 = new Library.LibAccountence();
            this.LibSidebarPan = new System.Windows.Forms.Panel();
            this.NewLibButton = new System.Windows.Forms.Button();
            this.SearchLibButton = new System.Windows.Forms.Button();
            this.AccLibButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.whoiamPanel.SuspendLayout();
            this.LibrarianPanel.SuspendLayout();
            this.RegLibPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.LibSidebarPan.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.startingText.Size = new System.Drawing.Size(840, 477);
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
            this.readerButton.Location = new System.Drawing.Point(423, 185);
            this.readerButton.Name = "readerButton";
            this.readerButton.Size = new System.Drawing.Size(170, 50);
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
            this.librarianButton.Location = new System.Drawing.Point(247, 241);
            this.librarianButton.Name = "librarianButton";
            this.librarianButton.Size = new System.Drawing.Size(170, 50);
            this.librarianButton.TabIndex = 3;
            this.librarianButton.Text = "Я бібліотекар";
            this.librarianButton.UseVisualStyleBackColor = false;
            this.librarianButton.Click += new System.EventHandler(this.librarianButton_Click);
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
            this.headButton.Location = new System.Drawing.Point(247, 185);
            this.headButton.Name = "headButton";
            this.headButton.Size = new System.Drawing.Size(170, 50);
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
            this.decButton.Location = new System.Drawing.Point(423, 241);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(170, 50);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(209, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(153, 189);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginLabel.Location = new System.Drawing.Point(48, 10);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(56, 26);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Вхід";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(6, 57);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(140, 26);
            this.loginTextBox.TabIndex = 1;
            // 
            // loginPassTextBox
            // 
            this.loginPassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPassTextBox.Location = new System.Drawing.Point(6, 104);
            this.loginPassTextBox.Name = "loginPassTextBox";
            this.loginPassTextBox.Size = new System.Drawing.Size(140, 26);
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
            this.loginButton.Location = new System.Drawing.Point(26, 150);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Увійти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.DimGray;
            this.authPanel.Controls.Add(this.tableLayoutPanel3);
            this.authPanel.Controls.Add(this.tableLayoutPanel1);
            this.authPanel.Location = new System.Drawing.Point(244, 140);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(369, 208);
            this.authPanel.TabIndex = 9;
            this.authPanel.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 189);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я користувача";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(121, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
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
            this.whoiamPanel.Location = new System.Drawing.Point(0, 0);
            this.whoiamPanel.Name = "whoiamPanel";
            this.whoiamPanel.RowCount = 2;
            this.whoiamPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.whoiamPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.whoiamPanel.Size = new System.Drawing.Size(840, 477);
            this.whoiamPanel.TabIndex = 10;
            this.whoiamPanel.Visible = false;
            // 
            // LibrarianPanel
            // 
            this.LibrarianPanel.Controls.Add(this.libSearch1);
            this.LibrarianPanel.Controls.Add(this.libAccountence1);
            this.LibrarianPanel.Controls.Add(this.LibSidebarPan);
            this.LibrarianPanel.Controls.Add(this.RegLibPanel);
            this.LibrarianPanel.Location = new System.Drawing.Point(0, 0);
            this.LibrarianPanel.Name = "LibrarianPanel";
            this.LibrarianPanel.Size = new System.Drawing.Size(840, 477);
            this.LibrarianPanel.TabIndex = 11;
            this.LibrarianPanel.Visible = false;
            // 
            // RegLibPanel
            // 
            this.RegLibPanel.Controls.Add(this.panel1);
            this.RegLibPanel.Controls.Add(this.label6);
            this.RegLibPanel.Location = new System.Drawing.Point(247, 42);
            this.RegLibPanel.Name = "RegLibPanel";
            this.RegLibPanel.Size = new System.Drawing.Size(550, 306);
            this.RegLibPanel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(97, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Реєстрація нового читача";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 189);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ім\'я користувача";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(90, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пароль";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.regLibTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.passLibTextBox, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.RegLibButton, 0, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(199, 14);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(153, 189);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Реєстрація";
            // 
            // regLibTextBox
            // 
            this.regLibTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regLibTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLibTextBox.Location = new System.Drawing.Point(6, 56);
            this.regLibTextBox.Name = "regLibTextBox";
            this.regLibTextBox.Size = new System.Drawing.Size(140, 29);
            this.regLibTextBox.TabIndex = 1;
            // 
            // passLibTextBox
            // 
            this.passLibTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passLibTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLibTextBox.Location = new System.Drawing.Point(6, 103);
            this.passLibTextBox.Name = "passLibTextBox";
            this.passLibTextBox.Size = new System.Drawing.Size(140, 29);
            this.passLibTextBox.TabIndex = 2;
            // 
            // RegLibButton
            // 
            this.RegLibButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegLibButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.RegLibButton.FlatAppearance.BorderSize = 0;
            this.RegLibButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegLibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLibButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RegLibButton.Location = new System.Drawing.Point(26, 150);
            this.RegLibButton.Name = "RegLibButton";
            this.RegLibButton.Size = new System.Drawing.Size(100, 30);
            this.RegLibButton.TabIndex = 3;
            this.RegLibButton.Text = "Зареєструвати";
            this.RegLibButton.UseVisualStyleBackColor = true;
            // 
            // libSearch1
            // 
            this.libSearch1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.libSearch1.Location = new System.Drawing.Point(244, 42);
            this.libSearch1.Name = "libSearch1";
            this.libSearch1.Size = new System.Drawing.Size(550, 290);
            this.libSearch1.TabIndex = 2;
            // 
            // libAccountence1
            // 
            this.libAccountence1.Location = new System.Drawing.Point(247, 33);
            this.libAccountence1.Name = "libAccountence1";
            this.libAccountence1.Size = new System.Drawing.Size(550, 290);
            this.libAccountence1.TabIndex = 1;
            // 
            // LibSidebarPan
            // 
            this.LibSidebarPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.LibSidebarPan.Controls.Add(this.NewLibButton);
            this.LibSidebarPan.Controls.Add(this.SearchLibButton);
            this.LibSidebarPan.Controls.Add(this.AccLibButton);
            this.LibSidebarPan.Location = new System.Drawing.Point(0, 0);
            this.LibSidebarPan.Name = "LibSidebarPan";
            this.LibSidebarPan.Size = new System.Drawing.Size(218, 477);
            this.LibSidebarPan.TabIndex = 0;
            // 
            // NewLibButton
            // 
            this.NewLibButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.NewLibButton.FlatAppearance.BorderSize = 0;
            this.NewLibButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewLibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLibButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewLibButton.Location = new System.Drawing.Point(0, 222);
            this.NewLibButton.Name = "NewLibButton";
            this.NewLibButton.Size = new System.Drawing.Size(218, 41);
            this.NewLibButton.TabIndex = 2;
            this.NewLibButton.Text = "Новий читач";
            this.NewLibButton.UseVisualStyleBackColor = false;
            this.NewLibButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchLibButton
            // 
            this.SearchLibButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.SearchLibButton.FlatAppearance.BorderSize = 0;
            this.SearchLibButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchLibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLibButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchLibButton.Location = new System.Drawing.Point(0, 175);
            this.SearchLibButton.Name = "SearchLibButton";
            this.SearchLibButton.Size = new System.Drawing.Size(218, 41);
            this.SearchLibButton.TabIndex = 1;
            this.SearchLibButton.Text = "Пошук";
            this.SearchLibButton.UseVisualStyleBackColor = false;
            this.SearchLibButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccLibButton
            // 
            this.AccLibButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.AccLibButton.FlatAppearance.BorderSize = 0;
            this.AccLibButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccLibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccLibButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AccLibButton.Location = new System.Drawing.Point(0, 128);
            this.AccLibButton.Name = "AccLibButton";
            this.AccLibButton.Size = new System.Drawing.Size(218, 41);
            this.AccLibButton.TabIndex = 0;
            this.AccLibButton.Text = "Облік";
            this.AccLibButton.UseVisualStyleBackColor = false;
            this.AccLibButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Location = new System.Drawing.Point(67, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 216);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(840, 477);
            this.Controls.Add(this.LibrarianPanel);
            this.Controls.Add(this.whoiamPanel);
            this.Controls.Add(this.startingText);
            this.Controls.Add(this.authPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.authPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.whoiamPanel.ResumeLayout(false);
            this.LibrarianPanel.ResumeLayout(false);
            this.RegLibPanel.ResumeLayout(false);
            this.RegLibPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.LibSidebarPan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel authPanel;
        private System.Windows.Forms.TableLayoutPanel whoiamPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LibrarianPanel;
        private System.Windows.Forms.Panel LibSidebarPan;
        private System.Windows.Forms.Button NewLibButton;
        private System.Windows.Forms.Button SearchLibButton;
        private System.Windows.Forms.Button AccLibButton;
        private LibSearch libSearch1;
        private LibAccountence libAccountence1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regLibTextBox;
        private System.Windows.Forms.TextBox passLibTextBox;
        private System.Windows.Forms.Button RegLibButton;
        private System.Windows.Forms.Panel RegLibPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}

