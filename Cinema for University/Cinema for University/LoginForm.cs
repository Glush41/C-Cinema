using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema_for_University
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginField.Text = "Логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Пароль";
            passField.ForeColor = Color.Gray;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (passField.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                if (loginField.Text == "Admin")
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                if (loginField.Text != "Admin")
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();    
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.Yellow;
        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
           RegisterLabel.ForeColor = Color.White;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Пароль";
                passField.ForeColor = Color.Gray;
            }
        }
        
    }
}
