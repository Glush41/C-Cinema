namespace Cinema_for_University
{
    partial class AdminForm
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
            this.PriceField = new System.Windows.Forms.TextBox();
            this.MoveToLoginButton = new System.Windows.Forms.Button();
            this.buttonSaveAdmin = new System.Windows.Forms.Button();
            this.DurationField = new System.Windows.Forms.TextBox();
            this.GenreField = new System.Windows.Forms.TextBox();
            this.MainActorField = new System.Windows.Forms.TextBox();
            this.CountryField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.TicketsField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.MainPanel.Controls.Add(this.PriceField);
            this.MainPanel.Controls.Add(this.MoveToLoginButton);
            this.MainPanel.Controls.Add(this.buttonSaveAdmin);
            this.MainPanel.Controls.Add(this.DurationField);
            this.MainPanel.Controls.Add(this.GenreField);
            this.MainPanel.Controls.Add(this.MainActorField);
            this.MainPanel.Controls.Add(this.CountryField);
            this.MainPanel.Controls.Add(this.NameField);
            this.MainPanel.Controls.Add(this.TicketsField);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(816, 507);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceField.Location = new System.Drawing.Point(450, 118);
            this.PriceField.Multiline = true;
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(327, 44);
            this.PriceField.TabIndex = 13;
            this.PriceField.Enter += new System.EventHandler(this.PriceField_Enter);
            this.PriceField.Leave += new System.EventHandler(this.PriceField_Leave);
            // 
            // MoveToLoginButton
            // 
            this.MoveToLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.MoveToLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveToLoginButton.FlatAppearance.BorderSize = 0;
            this.MoveToLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(59)))), ((int)(((byte)(11)))));
            this.MoveToLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(147)))), ((int)(((byte)(21)))));
            this.MoveToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveToLoginButton.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveToLoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoveToLoginButton.Location = new System.Drawing.Point(11, 438);
            this.MoveToLoginButton.Name = "MoveToLoginButton";
            this.MoveToLoginButton.Size = new System.Drawing.Size(397, 61);
            this.MoveToLoginButton.TabIndex = 12;
            this.MoveToLoginButton.Text = "Вернуться для авторизации";
            this.MoveToLoginButton.UseVisualStyleBackColor = false;
            this.MoveToLoginButton.Click += new System.EventHandler(this.MoveToLoginButton_Click);
            // 
            // buttonSaveAdmin
            // 
            this.buttonSaveAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.buttonSaveAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveAdmin.FlatAppearance.BorderSize = 0;
            this.buttonSaveAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(59)))), ((int)(((byte)(11)))));
            this.buttonSaveAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(147)))), ((int)(((byte)(21)))));
            this.buttonSaveAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAdmin.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveAdmin.Location = new System.Drawing.Point(493, 438);
            this.buttonSaveAdmin.Name = "buttonSaveAdmin";
            this.buttonSaveAdmin.Size = new System.Drawing.Size(311, 61);
            this.buttonSaveAdmin.TabIndex = 11;
            this.buttonSaveAdmin.Text = "Сохранить фильм!";
            this.buttonSaveAdmin.UseVisualStyleBackColor = false;
            this.buttonSaveAdmin.Click += new System.EventHandler(this.buttonSaveAdmin_Click);
            // 
            // DurationField
            // 
            this.DurationField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationField.Location = new System.Drawing.Point(34, 347);
            this.DurationField.Multiline = true;
            this.DurationField.Name = "DurationField";
            this.DurationField.Size = new System.Drawing.Size(374, 50);
            this.DurationField.TabIndex = 10;
            this.DurationField.Enter += new System.EventHandler(this.DurationField_Enter);
            this.DurationField.Leave += new System.EventHandler(this.DurationField_Leave);
            // 
            // GenreField
            // 
            this.GenreField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreField.Location = new System.Drawing.Point(450, 301);
            this.GenreField.Multiline = true;
            this.GenreField.Name = "GenreField";
            this.GenreField.Size = new System.Drawing.Size(327, 50);
            this.GenreField.TabIndex = 9;
            this.GenreField.Enter += new System.EventHandler(this.GenreField_Enter);
            this.GenreField.Leave += new System.EventHandler(this.GenreField_Leave);
            // 
            // MainActorField
            // 
            this.MainActorField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainActorField.Location = new System.Drawing.Point(450, 168);
            this.MainActorField.Multiline = true;
            this.MainActorField.Name = "MainActorField";
            this.MainActorField.Size = new System.Drawing.Size(327, 44);
            this.MainActorField.TabIndex = 8;
            this.MainActorField.Enter += new System.EventHandler(this.MainActorField_Enter);
            this.MainActorField.Leave += new System.EventHandler(this.MainActorField_Leave);
            // 
            // CountryField
            // 
            this.CountryField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryField.Location = new System.Drawing.Point(34, 168);
            this.CountryField.Multiline = true;
            this.CountryField.Name = "CountryField";
            this.CountryField.Size = new System.Drawing.Size(297, 44);
            this.CountryField.TabIndex = 7;
            this.CountryField.Enter += new System.EventHandler(this.CountryField_Enter);
            this.CountryField.Leave += new System.EventHandler(this.CountryField_Leave);
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(34, 118);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(297, 44);
            this.NameField.TabIndex = 6;
            this.NameField.Enter += new System.EventHandler(this.NameField_Enter);
            this.NameField.Leave += new System.EventHandler(this.NameField_Leave);
            // 
            // TicketsField
            // 
            this.TicketsField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketsField.Location = new System.Drawing.Point(34, 268);
            this.TicketsField.Multiline = true;
            this.TicketsField.Name = "TicketsField";
            this.TicketsField.Size = new System.Drawing.Size(374, 44);
            this.TicketsField.TabIndex = 5;
            this.TicketsField.Enter += new System.EventHandler(this.TicketsField_Enter);
            this.TicketsField.Leave += new System.EventHandler(this.TicketsField_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(2)))), ((int)(((byte)(14)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 100);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(790, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.label1.Size = new System.Drawing.Size(816, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню Администратора";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 507);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TicketsField;
        private System.Windows.Forms.TextBox DurationField;
        private System.Windows.Forms.TextBox GenreField;
        private System.Windows.Forms.TextBox MainActorField;
        private System.Windows.Forms.TextBox CountryField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Button buttonSaveAdmin;
        private System.Windows.Forms.Button MoveToLoginButton;
        private System.Windows.Forms.TextBox PriceField;
    }
}