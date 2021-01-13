using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LaboMonopoly_Affaires
{
        public class Terrain : Propriete
        {
            protected decimal _prixAchatMaison;
            protected decimal _prixLocationBase;
            protected int _nbMaisonsConstruites;

            public Terrain(string nm, decimal pr, decimal pm, decimal pl) : base(nm, pr)
            {
                _prixAchatMaison = pm;
                _prixLocationBase = pl;
                _nbMaisonsConstruites = 0;
            }
            public decimal PrixAchatMaison { get { return _prixAchatMaison; } }
            public decimal PrixLocationBase { get { return _prixLocationBase; } }
            public int NbMaisonsConstruites { get { return _nbMaisonsConstruites; } }

            public void acheterMaison()
            {
                if (_nbMaisonsConstruites < 5)
                    _nbMaisonsConstruites++;
            }
            public void vendreMaison()
            {
                if (_nbMaisonsConstruites > 0)
                    _nbMaisonsConstruites--;
            }

            public override decimal calculerCoutLocation()
            {
                decimal cout = _prixLocationBase * 5.0m;
                if (this.estAVendre() || this.EstEnHypotheque)
                    cout = 0.0m;
                else
                    if (_nbMaisonsConstruites == 5)
                        cout = _prixLocationBase * 75.0m;
                    else
                        if (_nbMaisonsConstruites == 2)
                            cout = _prixLocationBase * 15.0m;
                        else
                            if (_nbMaisonsConstruites == 3)
                                cout = _prixLocationBase * 45.0m;
                            else
                                if (_nbMaisonsConstruites == 4)
                                    cout = _prixLocationBase * 60.0m;
                return cout;
            }

            public SolidColorBrush Couleur
            {
                get
                {
                    switch(_nom)
                    {
                        case "Avenue de la Baltique":
                        case "Avenue de la Méditerranée":
                            return Brushes.SaddleBrown;
                        case "Avenue de l'Orient":
                        case "Avenue Vermont":
                        case "Avenue Connecticut":
                            return Brushes.PaleTurquoise;
                        case "Place St-Charles":
                        case "Avenue des États-Unis":
                        case "Avenue Virginie":
                            return Brushes.Pink;
                        case "Place St-Jacques":
                        case "Avenue Tennessee":
                        case "Avenue New York":
                            return Brushes.Orange;
                        case "Avenue Kentucky":
                        case "Avenue Indiana":
                        case "Avenue Illinois":
                            return Brushes.Red;
                        case "Avenue Atlantique":
                        case "Avenue Ventnor":
                        case "Jardins Marvin":
                            return Brushes.Yellow;
                        case "Avenue Pacifique":
                        case "Avenue Caroline du Nord":
                        case "Avenue Pennsylvanie":
                            return Brushes.ForestGreen;
                        case "Place du Parc":
                        case "Promenade":
                            return Brushes.Blue;
                    }
                    return null;
                }
            }

            public SolidColorBrush CouleurTitre
            {
                get
                {
                    switch (_nom)
                    {
                        case "Avenue de la Baltique":
                        case "Avenue de la Méditerranée":
                            return Brushes.White;
                        case "Avenue de l'Orient":
                        case "Avenue Vermont":
                        case "Avenue Connecticut":
                            return Brushes.Black;
                        case "Place St-Charles":
                        case "Avenue des États-Unis":
                        case "Avenue Virginie":
                            return Brushes.Black;
                        case "Place St-Jacques":
                        case "Avenue Tennessee":
                        case "Avenue New York":
                            return Brushes.Black;
                        case "Avenue Kentucky":
                        case "Avenue Indiana":
                        case "Avenue Illinois":
                            return Brushes.White;
                        case "Avenue Atlantique":
                        case "Avenue Ventnor":
                        case "Jardins Marvin":
                            return Brushes.Black;
                        case "Avenue Pacifique":
                        case "Avenue Caroline du Nord":
                        case "Avenue Pennsylvanie":
                            return Brushes.White;
                        case "Place du Parc":
                        case "Promenade":
                            return Brushes.White;
                    }
                    return null;
                }
            }
        }

}
