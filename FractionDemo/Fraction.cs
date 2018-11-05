using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FractionDemo
{
    class Fraction
    {
        #region Constructeur et destructeur
        public Fraction() : this(0, 0) { }

        public Fraction(int numerateur, int denominateur)
        {
            this.numerateur = numerateur;
            this.denominateur = denominateur;
            this.nom = "Fraction" + numero.ToString();
            numero++;
        }

        ~Fraction() //Ceci est le destructeur
        {
            //MessageBox.Show("Destruction de l'objet");
        }
        #endregion

        #region Propriétés
        private Int32 _numerateur;
        public Int32 numerateur
        {
            set { _numerateur = value; }
            get { return _numerateur; }
        }
        public Int32 denominateur { get; set; }

        /*Attention! utilisation de ces propriétés:
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
        public String nom { get; set; }
        private static Int32 numero = 1;
        #endregion

        #region méthodes
        public String toText()
        {
            return numerateur.ToString() + "/" + denominateur.ToString();
        }

        public void inverser()
        {
            if (numerateur != 0)
            {
                Int32 temp = numerateur;
                numerateur = denominateur;
                denominateur = temp;
            }
        }

        private Int32 pgcd()
        {
            Int32 r;
            Int32 n = numerateur;
            Int32 d = denominateur;
            while (true)
            {
                r = n % d;
                if (r == 0) { break; }
                n = d;
                d = r;
            }
            return d;
        }

        public void simplifier()
        {
            if (numerateur != 0)
            {
                Int32 p = pgcd();
                numerateur = numerateur / p;
                denominateur = denominateur / p;
            }
        }
        public static Fraction Parse(String str)
        {
            String[] strs = str.Split('/');
            return new Fraction(Int32.Parse(strs[0]), Int32.Parse(strs[1]));
        }
        #endregion

        #region Surchage d'opérateurs
        public static Fraction operator +(Fraction f, Fraction g)
        {
            return new Fraction(((f.numerateur * g.denominateur) + (f.denominateur * g.numerateur)), (f.denominateur * g.denominateur));
        }

        public static Fraction operator -(Fraction f, Fraction g)
        {
            return new Fraction(((f.numerateur * g.denominateur) - (f.denominateur * g.numerateur)), (f.denominateur * g.denominateur));
        }

        public static Fraction operator *(Fraction f, Fraction g)
        {
            return new Fraction((f.numerateur * g.numerateur), (f.denominateur * g.denominateur));
        }

        public static Fraction operator *(Fraction f, Int32 i)
        {
            return new Fraction((f.numerateur * i), f.denominateur);
        }

        public static Fraction operator /(Fraction f, Fraction g)
        {
            return new Fraction((f.numerateur * g.denominateur), (f.denominateur * g.numerateur));
        }

        public static Fraction operator /(Fraction f, Int32 i)
        {
            return new Fraction(f.numerateur, (f.denominateur * i));
        }

        public static Boolean operator ==(Fraction f, Fraction g)
        {
            f.simplifier();
            g.simplifier();
            if (f.numerateur == g.numerateur && f.denominateur == g.denominateur) { return true; }
            else { return false; }
        }

        public static Boolean operator !=(Fraction f, Fraction g)
        {
            f.simplifier();
            g.simplifier();
            if (f.numerateur == g.numerateur && f.denominateur == g.denominateur) { return false; }
            else { return true; }
        }

        public static Boolean operator >(Fraction f, Fraction g)
        {
            f.simplifier();
            g.simplifier();
            if (f.numerateur > g.numerateur && f.denominateur > g.denominateur) { return true; }
            else { return false; }
        }

        public static Boolean operator <(Fraction f, Fraction g)
        {
            f.simplifier();
            g.simplifier();
            if (f.numerateur < g.numerateur && f.denominateur < g.denominateur) { return true; }
            else { return false; }
        }
        #endregion
    }
}

