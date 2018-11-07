using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDemo
{
    class Centieme : Fraction
    {
        public Centieme(int numerateur, int denominateur) : base()
        {
            if (denominateur != 100)
            {
                this.denominateur = 100;
                this.numerateur = numerateur * this.denominateur / denominateur;
            }
            else
            {
                this.denominateur = denominateur;
                this.numerateur = numerateur;
            }
        }

        public new Int32 numerateur { get; set; }
        /// <summary>
        /// Lecture seule
        /// </summary>
        public new Int32 denominateur { get; }
        

        public new String toText()
        {
            return numerateur.ToString() + "\n" + "---" + "\n" + denominateur.ToString();
        }

        public override String ToString()
        {
            return numerateur.ToString() + "/" + denominateur.ToString();
        }
    }
}
