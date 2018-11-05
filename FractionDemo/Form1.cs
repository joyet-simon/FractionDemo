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
            Fraction f = new Fraction(9, 6);
            //MessageBox.Show(f.valeur.ToString());
            //f.simplifier();
            //MessageBox.Show(f.toText());
            //f.inverser();
            //MessageBox.Show(f.toText());
            //MessageBox.Show(f.nom);
            String s = "7/5";
            Fraction f2 = Fraction.Parse(s);
            Fraction f3 = f2 / 3;
            MessageBox.Show(f3.toText());
            if(f != f2) { MessageBox.Show("ok"); }
        }
    }
}
