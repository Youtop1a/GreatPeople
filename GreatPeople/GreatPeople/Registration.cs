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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // создание нового пользователя
            Main newForm = new Main();
            this.Hide();
            newForm.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Authorization newForm = new Authorization();
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
