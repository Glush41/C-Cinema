using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Cinema_for_University
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            NameFilmField.Text = "Введите название фильма";
            NameFilmField.ForeColor = Color.Gray;
            PriceField.Text = "Введите нужную цену";
            PriceField.ForeColor = Color.Gray;
            CounterTickets.Text = "Количество билетов";
            CounterTickets.ForeColor = Color.Gray;
            NameForSearchField.Text = "Введите нужное название";
            NameForSearchField.ForeColor = Color.Gray;
        }
        
        Point LastPoint;
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT Tickets, Price, Title FROM `films` WHERE `Title` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = NameFilmField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string tickets = table.Rows[0][0].ToString();
                string price = table.Rows[0][1].ToString();
                string title = table.Rows[0][2].ToString();
                MessageBox.Show($"Найден фильм '{title}' на который существует {tickets} билетов по цене:{price}");
                
            }
            else {
                MessageBox.Show("По вашему запросу ничего не найдено");
            }
        }

        private void NameFilmField_Enter(object sender, EventArgs e)
        {
            if (NameFilmField.Text == "Введите название фильма")
            {
                NameFilmField.Text = "";
                NameFilmField.ForeColor = Color.Black;
            }
        }

        private void NameFilmField_Leave(object sender, EventArgs e)
        {
            if (NameFilmField.Text == "")
            {
                NameFilmField.Text = "Введите название фильма";
                NameFilmField.ForeColor = Color.Gray;
            }
        }

        private void SearchPrice_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT Title, Tickets FROM `films` WHERE `Price` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = PriceField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string title = table.Rows[0][0].ToString();
                string tickets = table.Rows[0][1].ToString();
                MessageBox.Show($"Найден фильм под названием '{title}' и доступными {tickets} билетами");

            }
            else
            {
                MessageBox.Show("По вашему запросу ничего не найдено");
            }
        }

        private void PriceField_Enter(object sender, EventArgs e)
        {
            if (PriceField.Text == "Введите нужную цену")
            {
                PriceField.Text = "";
                PriceField.ForeColor = Color.Black;
            }
        }

        private void PriceField_Leave(object sender, EventArgs e)
        {
            if (PriceField.Text == "")
            {
                PriceField.Text = "Введите нужную цену";
                PriceField.ForeColor = Color.Gray;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT Tickets, Price, Title FROM `films` WHERE `Title` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = NameForSearchField.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {   
                string tickets1 = table.Rows[0][0].ToString();
                int tickets = int.Parse(tickets1);
                int price = (int)table.Rows[0][1];
                string title = table.Rows[0][2].ToString();
                string answer = CounterTickets.Text;
                int answer2 = price * int.Parse(answer);
                MessageBox.Show($"{answer} билет(-ов) на фильм '{title}' будет(-ут) стоить : {answer2}");

            }
            else
            {
                MessageBox.Show("По вашему запросу ничего не найдено");
            }
        }

        private void CounterTickets_Enter(object sender, EventArgs e)
        {
            if (CounterTickets.Text == "Количество билетов")
            {
                CounterTickets.Text = "";
                CounterTickets.ForeColor = Color.Black;
            }
        }

        private void CounterTickets_Leave(object sender, EventArgs e)
        {
            if (CounterTickets.Text == "")
            {
                CounterTickets.Text = "Количество билетов";
                CounterTickets.ForeColor = Color.Gray;
            }
        }

        private void NameForSearchField_Enter(object sender, EventArgs e)
        {
            if (NameForSearchField.Text == "Введите нужное название")
            {
                NameForSearchField.Text = "";
                NameForSearchField.ForeColor = Color.Black;
            }
        }

        private void NameForSearchField_Leave(object sender, EventArgs e)
        {
            if (NameForSearchField.Text == "")
            {
                NameForSearchField.Text = "Введите нужное название";
                NameForSearchField.ForeColor = Color.Gray;
            }
        }
        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.Yellow;
        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.White;
        }
    }
}

