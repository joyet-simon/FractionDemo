using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionDemo
{
    class NumBox : TextBox
    {
        public NumBox() : base()
        {
            this.Validating += validation;
        }

        public NumBox(double mini, double maxi) : base()
        {
            this.mini = mini;
            this.maxi = maxi;
            this.Validating += validation;

        }

        public Double mini { get; set; }
        public Double maxi { get; set; }


        public Boolean isInInterval(Double saisie)
        {
            if (maxi < mini)
            {
                Double temp = mini;
                mini = maxi;
                maxi = temp;
            }
            return (saisie <= maxi && saisie >= mini) ? true : false;
        }

        private void validation(Object sender, CancelEventArgs e)
        {
            this.BackColor = Color.White;
            Double saisie;
            if (Double.TryParse(this.Text, out saisie))
            {
                if (!isInInterval(saisie))
                {
                    this.BackColor = Color.Red;
                    e.Cancel = true;
                }
            }
            else
            {
                this.BackColor = Color.Teal;
                e.Cancel = true;
            }
        }



    }
}
