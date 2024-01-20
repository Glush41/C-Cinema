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

namespace Cinema_for_University
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            NameField.Text = "Название Фильма";
            NameField.ForeColor = Color.Gray;
            PriceField.Text = "Цена билета";
            PriceField.ForeColor = Color.Gray;
            CountryField.Text = "Страна";
            CountryField.ForeColor = Color.Gray;
            MainActorField.Text = "Главный Актёр";
            MainActorField.ForeColor = Color.Gray;
            TicketsField.Text = "Количество билетов";
            TicketsField.ForeColor = Color.Gray;
            GenreField.Text = "Жанр";
            GenreField.ForeColor = Color.Gray;
            DurationField.Text = "Продолжительность(минуты)";
            DurationField.ForeColor = Color.Gray;

        }

        private void buttonSaveAdmin_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "Название Фильма")
            {
                MessageBox.Show("Введите название фильма!");
                return;
            }
            if (CountryField.Text == "Страна")
            {
                MessageBox.Show("Введите название страны!");
                return;
            }
            if (MainActorField.Text == "Главный Актёр")
            {
                MessageBox.Show("Введите имя главного Актёра!");
                return;
            }
            if (TicketsField.Text == "Количество билетов")
            {
                MessageBox.Show("Введите количество билетов!");
                return;
            }
            if (GenreField.Text == "Жанр")
            {
                MessageBox.Show("Введите жанр фильма!");
                return;
            }
            if (DurationField.Text == "Продолжительность(минуты)")
            {
                MessageBox.Show("Введите продолжительность фильма!");
                return;
            }
            if (NameField.Text == "Цена билета")
            {
                MessageBox.Show("Введите цену на 1 билет!");
                return;
            }
            String NameFilm = NameField.Text;
            String CountryFilm = CountryField.Text;
            String MainActorFilm = MainActorField.Text;
            String TicketsFilm = TicketsField.Text;
            String GenreFilm = GenreField.Text;
            String DurationFilm = DurationField.Text;
            String PriceFilm = PriceField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `films` (`Title`, `Country`, `Main_Actor`, `Tickets`, `Genre`, `Duration`,`Price` ) VALUES (@title,@country,@mainActor,@tickets,@genre,@duration, @price)", db.getConnection());
            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = NameFilm;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = CountryFilm;
            command.Parameters.Add("@mainActor", MySqlDbType.VarChar).Value = MainActorFilm;
            command.Parameters.Add("@tickets", MySqlDbType.VarChar).Value = TicketsFilm;
            command.Parameters.Add("@genre", MySqlDbType.VarChar).Value = GenreFilm;
            command.Parameters.Add("@duration", MySqlDbType.VarChar).Value = DurationFilm;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = PriceFilm;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show("Фильм сохранен!");
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
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

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Название Фильма")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Название Фильма";
                NameField.ForeColor = Color.Gray;
            }
        }

        private void CountryField_Enter(object sender, EventArgs e)
        {
            if (CountryField.Text == "Страна")
            {
                CountryField.Text = "";
                CountryField.ForeColor = Color.Black;
            }
        }

        private void CountryField_Leave(object sender, EventArgs e)
        {
            if (CountryField.Text == "")
            {
                CountryField.Text = "Страна";
                CountryField.ForeColor = Color.Gray;
            }
        }

        private void MainActorField_Enter(object sender, EventArgs e)
        {
            if (MainActorField.Text == "Главный Актёр")
            {
                MainActorField.Text = "";
                MainActorField.ForeColor = Color.Black;
            }
        }

        private void MainActorField_Leave(object sender, EventArgs e)
        {
            if (MainActorField.Text == "")
            {
                MainActorField.Text = "Главный Актёр";
                MainActorField.ForeColor = Color.Gray;
            }
        }

        private void TicketsField_Enter(object sender, EventArgs e)
        {
            if (TicketsField.Text == "Количество билетов")
            {
                TicketsField.Text = "";
                TicketsField.ForeColor = Color.Black;
            }
        }

        private void TicketsField_Leave(object sender, EventArgs e)
        {
            if (TicketsField.Text == "")
            {
                TicketsField.Text = "Количество билетов";
                TicketsField.ForeColor = Color.Gray;
            }
        }

        private void GenreField_Enter(object sender, EventArgs e)
        {
            if (GenreField.Text == "Жанр")
            {
                GenreField.Text = "";
                GenreField.ForeColor = Color.Black;
            }
        }

        private void GenreField_Leave(object sender, EventArgs e)
        {
            if (GenreField.Text == "")
            {
                GenreField.Text = "Жанр";
                GenreField.ForeColor = Color.Gray;
            }
        }

        private void DurationField_Enter(object sender, EventArgs e)
        {
            if (DurationField.Text == "Продолжительность(минуты)")
            {
                DurationField.Text = "";
                DurationField.ForeColor = Color.Black;
            }
        }

        private void DurationField_Leave(object sender, EventArgs e)
        {
            if (DurationField.Text == "")
            {
                DurationField.Text = "Продолжительность(минуты)";
                DurationField.ForeColor = Color.Gray;
            }
        }

        private void MoveToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void PriceField_Enter(object sender, EventArgs e)
        {
            if (PriceField.Text == "Цена билета")
            {
                PriceField.Text = "";
                PriceField.ForeColor = Color.Black;
            }
        }

        private void PriceField_Leave(object sender, EventArgs e)
        {
            if (PriceField.Text == "")
            {
                PriceField.Text = "Цена билета";
                PriceField.ForeColor = Color.Gray;
            }
        }
    }
}
