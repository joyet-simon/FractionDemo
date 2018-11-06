using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionDemo
{
    class ButtonLoop : Button
    {
        public ButtonLoop(bool loupe) : base()
        {
            this.loupe = loupe;
            this.MouseEnter += grossir;
            this.MouseLeave += retablir;
        }

        public ButtonLoop() : base()
        {
            this.MouseEnter += grossir;
            this.MouseLeave += retablir;
        }

        public Boolean loupe { get; set; }

        private void grossir(Object sender, EventArgs e)
        {
            if (loupe)
            {
                this.Left -= Width / 2;
                this.Top -= Height / 2;
                this.Width = Width * 2;
                this.Height = Height * 2;
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.BackColor = Color.Tomato;
            }
        }

        private void retablir(Object sender, EventArgs e)
        {
            this.Width = Width / 2;
            this.Height = Height / 2;
            this.Left += Width / 2;
            this.Top += Height / 2;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = Color.LightBlue;
        }
    }
}
