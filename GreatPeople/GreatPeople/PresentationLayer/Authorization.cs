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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            this.Hide();
            newForm.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            // проверка логина и пароля
            Main newForm = new Main();
            this.Hide();
            newForm.Show();
        }

        private void escapeButton_Click(object sender, EventArgs e)
        {
            Main newForm = new Main();
            this.Hide();
            newForm.Show();
        }
    }
}
