using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDemo
{
    class Fraction
    {
        private Int32 _numerateur;
        public Int32 numerateur
        {
            set
            {
                _numerateur = value;
            }
            get
            {
                return _numerateur;
            }
        }
        public Int32 denominateur { get; set; }

        /*Attention! utilisation de cex propriétés:
         * 
         * Fraction f = new Fraction();
         * f.numerateur=5;                    //Pour activer le setter
         * Int32 n = f.numerateur            //Pour activer le getter
         */

        /// <summary>
        /// Propriété en lecture seule : pas de setter.
        /// </summary>
        public Double valeur
        {
            get { return (Double)numerateur / (Double)denominateur; }
        }

        public String toText()
        {
            return numerateur.ToString() + "/" + denominateur.ToString();
        }

        public void inverser()
        {
            Int32 temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }

        private Int32 pgcd()
        {
            Int32 r;
            Int32 n = numerateur;
            Int32 d = denominateur;
            while (true)
            {
                r = n % d;
                if (r == 0)
                {
                    break;
                }
                n = d;
                d = r;
            }
            return d;
        }

        public void simplifier()
        {
            numerateur = numerateur / pgcd();
            denominateur = denominateur / pgcd();
        }
    }
}

