using BeeDone.Models;
using Microsoft.UI.Xaml;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeeDone
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        ObservableCollection<Tache> Taches = new ObservableCollection<Tache>();

        public MainWindow()
        {
            InitializeComponent();

            Taches.Add(new Tache("Faire l'épicerie"));
            Taches.Add(new Tache("Réviser WinUI"));
        }

        private void btnAjouterTache_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNouvelleTache.Text))
            {
                Tache nouvelleTache = new Tache(txtNouvelleTache.Text);

                Taches.Add(nouvelleTache);
                txtNouvelleTache.Text = string.Empty;
            }


        }

        //private void btnValider_Click(object sender, RoutedEventArgs e)
        //{
          //  string nom = txtNom.Text;
            //txtMessage.Text = $"Bonjour {nom}";

        //}
    }
}
