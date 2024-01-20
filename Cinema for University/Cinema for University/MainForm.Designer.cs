namespace Cinema_for_University
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.NameForSearchField = new System.Windows.Forms.TextBox();
            this.CounterTickets = new System.Windows.Forms.TextBox();
            this.SearchPrice = new System.Windows.Forms.Button();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.NameFilmField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.MainPanel.Controls.Add(this.RegisterLabel);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.Search);
            this.MainPanel.Controls.Add(this.NameForSearchField);
            this.MainPanel.Controls.Add(this.CounterTickets);
            this.MainPanel.Controls.Add(this.SearchPrice);
            this.MainPanel.Controls.Add(this.PriceField);
            this.MainPanel.Controls.Add(this.NameFilmField);
            this.MainPanel.Controls.Add(this.buttonRegister);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1012, 574);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisterLabel.Location = new System.Drawing.Point(809, 532);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(191, 19);
            this.RegisterLabel.TabIndex = 15;
            this.RegisterLabel.Text = "Вернуться на авторизацию!";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            this.RegisterLabel.MouseEnter += new System.EventHandler(this.RegisterLabel_MouseEnter);
            this.RegisterLabel.MouseLeave += new System.EventHandler(this.RegisterLabel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(2)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 68);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(896, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Рассчитайте стоймость нужного вам количества билетов на  определенный фильм!";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(59)))), ((int)(((byte)(11)))));
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(147)))), ((int)(((byte)(21)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Search.Location = new System.Drawing.Point(288, 490);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(442, 61);
            this.Search.TabIndex = 14;
            this.Search.Text = "Рассчитать стоймость билетов!";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // NameForSearchField
            // 
            this.NameForSearchField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameForSearchField.Location = new System.Drawing.Point(558, 408);
            this.NameForSearchField.Multiline = true;
            this.NameForSearchField.Name = "NameForSearchField";
            this.NameForSearchField.Size = new System.Drawing.Size(443, 67);
            this.NameForSearchField.TabIndex = 13;
            this.NameForSearchField.Enter += new System.EventHandler(this.NameForSearchField_Enter);
            this.NameForSearchField.Leave += new System.EventHandler(this.NameForSearchField_Leave);
            // 
            // CounterTickets
            // 
            this.CounterTickets.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterTickets.Location = new System.Drawing.Point(0, 408);
            this.CounterTickets.Multiline = true;
            this.CounterTickets.Name = "CounterTickets";
            this.CounterTickets.Size = new System.Drawing.Size(443, 67);
            this.CounterTickets.TabIndex = 12;
            this.CounterTickets.Enter += new System.EventHandler(this.CounterTickets_Enter);
            this.CounterTickets.Leave += new System.EventHandler(this.CounterTickets_Leave);
            // 
            // SearchPrice
            // 
            this.SearchPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.SearchPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPrice.FlatAppearance.BorderSize = 0;
            this.SearchPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(59)))), ((int)(((byte)(11)))));
            this.SearchPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(147)))), ((int)(((byte)(21)))));
            this.SearchPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPrice.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchPrice.Location = new System.Drawing.Point(558, 221);
            this.SearchPrice.Name = "SearchPrice";
            this.SearchPrice.Size = new System.Drawing.Size(442, 61);
            this.SearchPrice.TabIndex = 11;
            this.SearchPrice.Text = "Найти!";
            this.SearchPrice.UseVisualStyleBackColor = false;
            this.SearchPrice.Click += new System.EventHandler(this.SearchPrice_Click);
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceField.Location = new System.Drawing.Point(558, 134);
            this.PriceField.Multiline = true;
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(443, 64);
            this.PriceField.TabIndex = 10;
            this.PriceField.Enter += new System.EventHandler(this.PriceField_Enter);
            this.PriceField.Leave += new System.EventHandler(this.PriceField_Leave);
            // 
            // NameFilmField
            // 
            this.NameFilmField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFilmField.Location = new System.Drawing.Point(11, 134);
            this.NameFilmField.Multiline = true;
            this.NameFilmField.Name = "NameFilmField";
            this.NameFilmField.Size = new System.Drawing.Size(443, 64);
            this.NameFilmField.TabIndex = 9;
            this.NameFilmField.Enter += new System.EventHandler(this.NameFilmField_Enter);
            this.NameFilmField.Leave += new System.EventHandler(this.NameFilmField_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(59)))), ((int)(((byte)(11)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(147)))), ((int)(((byte)(21)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegister.Location = new System.Drawing.Point(12, 221);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(442, 61);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Найти!";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(2)))), ((int)(((byte)(14)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1012, 100);
            this.label2.TabIndex = 2;
            this.label2.Text = "Главный экран пользователя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(986, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 25);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1012, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главный экран пользователя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 574);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox NameFilmField;
        private System.Windows.Forms.Button SearchPrice;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox NameForSearchField;
        private System.Windows.Forms.TextBox CounterTickets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RegisterLabel;
    }
}