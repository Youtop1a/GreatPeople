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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authorization newForm = new Authorization();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            this.Hide();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bd newForm = new Bd();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            this.Hide();
            newForm.Show();
        }
    }
}
