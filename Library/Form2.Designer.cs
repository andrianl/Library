namespace Library
{
    partial class Form2
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
            this.LibSidebarPan = new System.Windows.Forms.Panel();
            this.NewHeadButton = new System.Windows.Forms.Button();
            this.SearchHeadButton = new System.Windows.Forms.Button();
            this.AccHeadButton = new System.Windows.Forms.Button();
            this.AccHeadBookButton = new System.Windows.Forms.Button();
            this.HeadSearch = new Library.LibSearch();
            this.RegHeadPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.regHeadTextBox = new System.Windows.Forms.TextBox();
            this.passHeadTextBox = new System.Windows.Forms.TextBox();
            this.RegHeadButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LibSidebarPan.SuspendLayout();
            this.RegHeadPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibSidebarPan
            // 
            this.LibSidebarPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.LibSidebarPan.Controls.Add(this.AccHeadBookButton);
            this.LibSidebarPan.Controls.Add(this.NewHeadButton);
            this.LibSidebarPan.Controls.Add(this.SearchHeadButton);
            this.LibSidebarPan.Controls.Add(this.AccHeadButton);
            this.LibSidebarPan.Location = new System.Drawing.Point(1, 2);
            this.LibSidebarPan.Name = "LibSidebarPan";
            this.LibSidebarPan.Size = new System.Drawing.Size(218, 477);
            this.LibSidebarPan.TabIndex = 3;
            // 
            // NewHeadButton
            // 
            this.NewHeadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.NewHeadButton.FlatAppearance.BorderSize = 0;
            this.NewHeadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewHeadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewHeadButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewHeadButton.Location = new System.Drawing.Point(0, 257);
            this.NewHeadButton.Name = "NewHeadButton";
            this.NewHeadButton.Size = new System.Drawing.Size(218, 41);
            this.NewHeadButton.TabIndex = 2;
            this.NewHeadButton.Text = "Новий бібліотекар";
            this.NewHeadButton.UseVisualStyleBackColor = false;
            this.NewHeadButton.Click += new System.EventHandler(this.NewHeadButton_Click);
            // 
            // SearchHeadButton
            // 
            this.SearchHeadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.SearchHeadButton.FlatAppearance.BorderSize = 0;
            this.SearchHeadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchHeadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchHeadButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchHeadButton.Location = new System.Drawing.Point(0, 210);
            this.SearchHeadButton.Name = "SearchHeadButton";
            this.SearchHeadButton.Size = new System.Drawing.Size(218, 41);
            this.SearchHeadButton.TabIndex = 1;
            this.SearchHeadButton.Text = "Пошук книги";
            this.SearchHeadButton.UseVisualStyleBackColor = false;
            this.SearchHeadButton.Click += new System.EventHandler(this.SearchHeadButton_Click);
            // 
            // AccHeadButton
            // 
            this.AccHeadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.AccHeadButton.FlatAppearance.BorderSize = 0;
            this.AccHeadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccHeadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccHeadButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AccHeadButton.Location = new System.Drawing.Point(0, 163);
            this.AccHeadButton.Name = "AccHeadButton";
            this.AccHeadButton.Size = new System.Drawing.Size(218, 41);
            this.AccHeadButton.TabIndex = 0;
            this.AccHeadButton.Text = "Облік читачів";
            this.AccHeadButton.UseVisualStyleBackColor = false;
            this.AccHeadButton.Click += new System.EventHandler(this.AccHeadButton_Click);
            // 
            // AccHeadBookButton
            // 
            this.AccHeadBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.AccHeadBookButton.FlatAppearance.BorderSize = 0;
            this.AccHeadBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccHeadBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccHeadBookButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AccHeadBookButton.Location = new System.Drawing.Point(0, 116);
            this.AccHeadBookButton.Name = "AccHeadBookButton";
            this.AccHeadBookButton.Size = new System.Drawing.Size(218, 41);
            this.AccHeadBookButton.TabIndex = 3;
            this.AccHeadBookButton.Text = "Облік бібліотекарів";
            this.AccHeadBookButton.UseVisualStyleBackColor = false;
            this.AccHeadBookButton.Click += new System.EventHandler(this.AccHeadBookButton_Click);
            // 
            // HeadSearch
            // 
            this.HeadSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeadSearch.Location = new System.Drawing.Point(241, 20);
            this.HeadSearch.Name = "HeadSearch";
            this.HeadSearch.Size = new System.Drawing.Size(591, 449);
            this.HeadSearch.TabIndex = 4;
            // 
            // RegHeadPanel
            // 
            this.RegHeadPanel.Controls.Add(this.panel1);
            this.RegHeadPanel.Controls.Add(this.label6);
            this.RegHeadPanel.Location = new System.Drawing.Point(241, 20);
            this.RegHeadPanel.Name = "RegHeadPanel";
            this.RegHeadPanel.Size = new System.Drawing.Size(591, 452);
            this.RegHeadPanel.TabIndex = 13;
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
            this.tableLayoutPanel4.Controls.Add(this.regHeadTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.passHeadTextBox, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.RegHeadButton, 0, 3);
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
            // regHeadTextBox
            // 
            this.regHeadTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regHeadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regHeadTextBox.Location = new System.Drawing.Point(6, 56);
            this.regHeadTextBox.Name = "regHeadTextBox";
            this.regHeadTextBox.Size = new System.Drawing.Size(140, 29);
            this.regHeadTextBox.TabIndex = 1;
            // 
            // passHeadTextBox
            // 
            this.passHeadTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passHeadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passHeadTextBox.Location = new System.Drawing.Point(6, 103);
            this.passHeadTextBox.Name = "passHeadTextBox";
            this.passHeadTextBox.Size = new System.Drawing.Size(140, 29);
            this.passHeadTextBox.TabIndex = 2;
            // 
            // RegHeadButton
            // 
            this.RegHeadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegHeadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.RegHeadButton.FlatAppearance.BorderSize = 0;
            this.RegHeadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegHeadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegHeadButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RegHeadButton.Location = new System.Drawing.Point(26, 150);
            this.RegHeadButton.Name = "RegHeadButton";
            this.RegHeadButton.Size = new System.Drawing.Size(100, 30);
            this.RegHeadButton.TabIndex = 3;
            this.RegHeadButton.Text = "Зареєструвати";
            this.RegHeadButton.UseVisualStyleBackColor = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(844, 481);
            this.Controls.Add(this.LibSidebarPan);
            this.Controls.Add(this.HeadSearch);
            this.Controls.Add(this.RegHeadPanel);
            this.Name = "Form2";
            this.Text = "Head";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.LibSidebarPan.ResumeLayout(false);
            this.RegHeadPanel.ResumeLayout(false);
            this.RegHeadPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LibSidebarPan;
        private System.Windows.Forms.Button NewHeadButton;
        private System.Windows.Forms.Button SearchHeadButton;
        private System.Windows.Forms.Button AccHeadButton;
        private System.Windows.Forms.Button AccHeadBookButton;
        private LibSearch HeadSearch;
        private System.Windows.Forms.Panel RegHeadPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regHeadTextBox;
        private System.Windows.Forms.TextBox passHeadTextBox;
        private System.Windows.Forms.Button RegHeadButton;
        private System.Windows.Forms.Label label6;
    }
}