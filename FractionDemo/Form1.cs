using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction f = new Fraction();
            f.denominateur = 6;
            f.numerateur = 9;
            f.simplifier();
            MessageBox.Show(f.toText());
            f.inverser();
            MessageBox.Show(f.toText());
        }
    }
}
