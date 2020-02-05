using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatPeople
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            int role = 3;
            switch (role)
            {
                case 1:
                    {
                        regGuestButton.Visible = true;
                        authGuestButton.Visible = true;
                        adminAddButton.Visible = false;
                        userStatisticButton.Visible = false;
                        adminRequestsButton.Visible = false;
                        adminExitButton.Visible = false;
                        userExitButton.Visible = false;
                        break;
                    }
                case 2:
                    {
                        regGuestButton.Visible = false;
                        authGuestButton.Visible = false;
                        adminAddButton.Visible = false;
                        userStatisticButton.Visible = true;
                        adminRequestsButton.Visible = false;
                        adminExitButton.Visible = false;
                        userExitButton.Visible = true;
                        break;
                    }
                case 3:
                    {
                        regGuestButton.Visible = false;
                        authGuestButton.Visible = false;
                        adminAddButton.Visible = true;
                        userStatisticButton.Visible = false;
                        adminRequestsButton.Visible = true;
                        adminExitButton.Visible = true;
                        userExitButton.Visible = false;
                        break;
                    }
            }
        }

        private void fioButton_Click(object sender, EventArgs e)
        {
            // поиск по фио
        }

        private void userExitButton_Click(object sender, EventArgs e)
        {
            // сделать роль гость
        }

        private void adminAddButton_Click(object sender, EventArgs e)
        {
            Bd newForm = new Bd();
            this.Hide();
            newForm.Show();
        }

        private void authGuestButton_Click(object sender, EventArgs e)
        {
            Authorization newForm = new Authorization();
            this.Hide();
            newForm.Show();
        }

        private void regGuestButton_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            this.Hide();
            newForm.Show();
        }

        private void adminExitButton_Click(object sender, EventArgs e)
        {
            //сделать роль гость
        }

        private void adminRequestsButton_Click(object sender, EventArgs e)
        {
            Requests newForm = new Requests();
            this.Hide();
            newForm.Show();
        }

        private void userStatisticButton_Click(object sender, EventArgs e)
        {
            // файл со статистикой
        }

        private void diapazonButton_Click(object sender, EventArgs e)
        {
            // поиск по диапозону времени жизни
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //тут если роль админ появяться кнопки на удаление у каждого челика
        }
    }
}
