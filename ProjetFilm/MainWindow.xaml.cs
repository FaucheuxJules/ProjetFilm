using FilmsMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetFilm
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Dictionary<string, List<Film>> dico;
        List<string> lesGenres;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dico = new Dictionary<string, List<Film>>();
            lesGenres = new List<string>();
            List<Film> filmsComedie  = new List<Film>();
            List<Film> filmsHorreur = new List<Film>();
            List<Film> filmsAventure = new List<Film>();
            List<Acteur> lesActeursTotal = new List<Acteur>(); 

            Acteur acteur1 = new Acteur("De Niro", "Robert", "Images/De Niro.png");



            Acteur acteur2 = new Acteur("Di Caprio", "Leonardo", "Images/Di Caprio.png");



            Acteur acteur3 = new Acteur("Nicholson", "Jack", "Images/Nicholson.png");



            Acteur acteur4 = new Acteur("Depp", "Johnny", "Images/Depp.png");



            Acteur acteur5 = new Acteur("Pitt", "Brad", "Images/Pitt.png");



            Acteur acteur6 = new Acteur("Portman", "Natalie", "Images/Portman.png");



            Acteur acteur7 = new Acteur("Lawrence", "Jennifer", "Images/Lawrence.png");



            Acteur acteur8 = new Acteur("Jolie", "Angelina", "Images/Jolie.png");



            Acteur acteur9 = new Acteur("Kidman", "Nicole", "Images/Kidman.png");



            Acteur acteur10 = new Acteur("Stone", "Emma", "Images/Stone.png");



            Realisateur real1 = new Realisateur("Tarantino", "Quentin", "Images/Tarantino.png");



            Realisateur real2 = new Realisateur("Spielberg", "Steven", "Images/Spielberg.png");



            Realisateur real3 = new Realisateur("Scorsese", "Martin", "Images/Scorsese.png");



            Film film1 = new Film("Film n°1", 23000, "Images/Film n°1.png", real1);



            Film film2 = new Film("Film n°2", 56000, "Images/Film n°2.png", real2);



            Film film3 = new Film("Film n°3", 21000, "Images/Film n°3.png", real3);
            film1.AjouterActeur(acteur1); film1.AjouterActeur(acteur2); film1.AjouterActeur(acteur3);
            film2.AjouterActeur(acteur4); film2.AjouterActeur(acteur5); film2.AjouterActeur(acteur6);
            film3.AjouterActeur(acteur2); film3.AjouterActeur(acteur8); film3.AjouterActeur(acteur4); film3.AjouterActeur(acteur10);

            filmsAventure.Add(film1);
            filmsComedie.Add(film2);
            filmsHorreur.Add(film3);

            dico.Add("Aventure", filmsAventure);
            dico.Add("Comédie", filmsComedie);
            dico.Add("Horreur", filmsHorreur);

            lesActeursTotal.Add(acteur1); lesActeursTotal.Add(acteur2); lesActeursTotal.Add(acteur3); lesActeursTotal.Add(acteur4); lesActeursTotal.Add(acteur5); lesActeursTotal.Add(acteur6);
            lesActeursTotal.Add(acteur7); lesActeursTotal.Add(acteur8); lesActeursTotal.Add(acteur9); lesActeursTotal.Add(acteur10);
            lesGenres.Add("Aventure"); lesGenres.Add("Comédie"); lesGenres.Add("Horreur");
            cboGenres.ItemsSource = lesGenres;
            lstActeursTotal.ItemsSource = lesActeursTotal;
        }

        private void cboGenres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cboGenres != null)
            {
                lstFilms.ItemsSource = dico[cboGenres.SelectedItem as string];
            }
            
        }

        private void lstFilms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstFilms.SelectedItem != null)
            {
                lstActeurs.ItemsSource = (lstFilms.SelectedItem as Film).LesActeurs;
            }
           
        }

        private void btnAjouterGenre_Click(object sender, RoutedEventArgs e)
        {
            if(txtGenre.Text == "")
            {
                MessageBox.Show("Veuillez entrer un genre", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if(dico.ContainsKey(txtGenre.Text) == true)
                {
                    MessageBox.Show("Le genre existe déjà", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    lesGenres.Add(txtGenre.Text as string);
                    List<Film> filmsAction = new List<Film>();
                    dico.Add(txtGenre.Text, filmsAction);
                    cboGenres.Items.Refresh();
                }
               
            }
           
        }

        private void lstActeurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAjouterFilm_Click(object sender, RoutedEventArgs e)
        {
            if(txtNomFilm.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom de film", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (txtNbEntrees.Text == "")
                {
                    MessageBox.Show("Veuillez entrer un nombre d'entrées", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (txtNomReal.Text == "")
                    {
                        MessageBox.Show("Veuillez entrer un nom de réalisateur", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        if (txtPrenomReal.Text == "")
                        {
                            MessageBox.Show("Veuillez entrer un prénom de réalisateur", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            if(cboGenres.SelectedItem == null)
                            {
                                MessageBox.Show("Veuillez choisir un genre", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            else
                            {
                                Realisateur r = new Realisateur(txtNomReal.Text, txtPrenomReal.Text, "Images/NewRealisateur.png");
                                Film f = new Film(txtNomFilm.Text, Convert.ToInt32(txtNbEntrees.Text), "Images/NewFilm.png", r);
                                f.AjouterActeur(lstActeursTotal.SelectedItems as Acteur);
                                dico[cboGenres.SelectedItem as string].Add(f);
                                lstFilms.Items.Refresh();
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
