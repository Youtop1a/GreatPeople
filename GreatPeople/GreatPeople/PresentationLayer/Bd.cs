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
    public partial class Bd : Form
    {
        public Bd()
        {
            InitializeComponent();
        }

        private void escapeButton_Click(object sender, EventArgs e)
        {
            Main newForm = new Main();
            this.Hide();
            newForm.Show();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            // Добавить нового челика
        }

    }
}
