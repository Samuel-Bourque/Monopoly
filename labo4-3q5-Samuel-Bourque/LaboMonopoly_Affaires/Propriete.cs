using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboMonopoly_Affaires
{
    public abstract class Propriete
    {
        protected string _nom;
        protected decimal _prixPropriete;
        protected bool _etatEnHypotheque;
        protected bool _etatAVendre;
        public Propriete(string nm, decimal pr)
        {
                _nom = nm;
                _prixPropriete = pr;
                _etatEnHypotheque = false;
                _etatAVendre = true;
        }
        public string Nom { get { return _nom; } }
        public decimal PrixPropriete { get { return _prixPropriete; } }

        public bool estAVendre() { return _etatAVendre; }
        public bool estVendu() { return !_etatAVendre; }
        public void acheter()
        {
            _etatAVendre = false;
        }

        public bool EstEnHypotheque { get { return _etatEnHypotheque; } }
        public void prendreHypotheque() { _etatEnHypotheque = true; }
        public void leverHypotheque() { _etatEnHypotheque = false; }
        public decimal calculerCoutHypotheque() { return _prixPropriete / 2; }

        public abstract decimal calculerCoutLocation();
    }
}
