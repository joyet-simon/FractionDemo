using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDemo
{
    class Centieme : Fraction
    {
        public Centieme(int numerateur, int denominateur) : base(numerateur, denominateur)
        {
            if (denominateur != 100)
            {
                base.denominateur = 100;
                this.numerateur = numerateur * 100 / denominateur;
            }
            else
            {
                base.denominateur = 100;
                this.numerateur = numerateur;
            }
        }

        /// <summary>
        /// Lecture seule
        /// </summary>
        public new Int32 denominateur { get; }

        public new String toText()
        {
            return numerateur.ToString() + "\n---\n100";
        }

        public override String ToString()
        {
            return base.toText();
        }
    }
}
