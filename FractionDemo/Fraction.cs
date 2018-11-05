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
            return numerateur + "/" + denominateur;
        }

        public void inverser()
        {
            Int32 temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }

        public void simplifier()
        {
            Int32 r;
            Int32 num = numerateur;
            Int32 denom = denominateur;
            while (true)
            {
                r = num % denom;
                if (r == 0)
                {
                    break;
                }
                num = denom;
                denom = r;
            }
            numerateur = numerateur / denom;
            denominateur = denominateur / denom;
        }
    }
}

