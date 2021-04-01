using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonSklad_Click(object sender, EventArgs e)
        {
            FormSklad fs = new FormSklad();
            fs.Show();
            this.Hide();
        }

        private void buttonMagazines_Click(object sender, EventArgs e)
        {
            FormMagazines fm = new FormMagazines();
            fm.Show();
            this.Hide();
        }
    }
}
