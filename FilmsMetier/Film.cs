using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsMetier
{
     public class Film
    {
        private Realisateur leRealisateur;
        private List<Acteur> lesActeurs;
        private int nbEntrees;
        private string photoFilm;
        private string titreFilm;

        public Film(string unTitre, int unNbEntrees, string unePhoto, Realisateur unRealisateur)
        {
            TitreFilm = unTitre;
            NbEntrees = unNbEntrees;
            PhotoFilm = unePhoto;
            LeRealisateur = unRealisateur;
            LesActeurs = new List<Acteur>();
            //test
        }

        public Realisateur LeRealisateur { get => leRealisateur; set => leRealisateur = value; }
        public List<Acteur> LesActeurs { get => lesActeurs; set => lesActeurs = value; }
        public int NbEntrees { get => nbEntrees; set => nbEntrees = value; }
        public string PhotoFilm { get => photoFilm; set => photoFilm = value; }
        public string TitreFilm { get => titreFilm; set => titreFilm = value; }

        public void AjouterActeur(Acteur unActeur)
        {
            lesActeurs.Add(unActeur);
        }
    }
}
