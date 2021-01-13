using LaboMonopoly_Affaires;
using System.Collections.ObjectModel;
using System.Windows;

namespace LaboMonopoly_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Propriete> Proprietes { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Proprietes = new ObservableCollection<Propriete>()
            {
                new Terrain("Avenue de la Baltique", 60m, 50m, 4m),
                new Terrain("Avenue de la Méditerranée", 60m, 50m, 4m),

                new Terrain("Avenue de l'Orient",100m,50m,6m),
                new Terrain("Avenue Vermont",100m,50m,6m),
                new Terrain("Avenue Connecticut",120m,50m,8m),

                new Terrain("Place St-Charles",140m,100m,10m),
                new Terrain("Avenue des États-Unis", 140m,100m,10m),
                new Terrain("Avenue Virginie",160m,100m,12m),

                new Terrain("Place St-Jacques",180m,100m,14m),
                new Terrain("Avenue Tennessee",180m,100m,14m),
                new Terrain("Avenue New York",200m,100m,16m),

                new Terrain("Avenue Kentucky",220m,150m,18m),
                new Terrain("Avenue Indiana",220m,150m,18m),
                new Terrain("Avenue Illinois",240m,150m,20m),

                new Terrain("Avenue Atlantique",260m,150m,22m),
                new Terrain("Avenue Ventnor",260m,150m,22m),
                new Terrain("Jardins Marvin",280m,150m,24m),

                new Terrain("Avenue Pacifique",300m,200m,26m),
                new Terrain("Avenue Caroline du Nord",300m,200m,26m),
                new Terrain("Avenue Pennsylvanie",320m,200m,28m),

                new Terrain("Place du Parc",350m,200m,35m),
                new Terrain("Promenade",400m,200m,50m),

                new ServicePublic("Aqueducs"),
                new ServicePublic("Cie électricité")
            };
            Proprietes[0].acheter();
            Proprietes[1].acheter();
            Proprietes[2].acheter();
            Proprietes[3].acheter();
            Proprietes[4].acheter();
            Proprietes[7].acheter();
            Proprietes[11].acheter();
            Proprietes[22].acheter();
            Proprietes[23].acheter();

            ((Terrain)Proprietes[1]).acheterMaison();
            ((Terrain)Proprietes[2]).acheterMaison();
            ((Terrain)Proprietes[2]).acheterMaison();
            ((Terrain)Proprietes[2]).acheterMaison();

            Proprietes[0].prendreHypotheque();
            Proprietes[3].prendreHypotheque();
            Proprietes[7].prendreHypotheque();
            Proprietes[11].prendreHypotheque();
            Proprietes[23].prendreHypotheque();
            panneau.DataContext = this;
        }
    }
}
