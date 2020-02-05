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
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void escapeButton_Click(object sender, EventArgs e)
        {
            Main newForm = new Main();
            this.Hide();
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // тут будут запросы с кнопками принять и отменить
        }
    }
}
