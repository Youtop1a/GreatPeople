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

        private void button2_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            this.Hide();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main newForm = new Main();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            this.Hide();
            newForm.Show();
        }
    }
}
