using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsMetier
{
    public class Realisateur
    {
        private string nomRealisateur;
        private string photoRealisateur;
        private string prenomRealisateur;

        public Realisateur(string unNom, string unPrenom, string unePhoto)
        {
            NomRealisateur = unNom;
            PhotoRealisateur = unePhoto;
            PrenomRealisateur = unPrenom;
        }

        public string NomRealisateur { get => nomRealisateur; set => nomRealisateur = value; }
        public string PhotoRealisateur { get => photoRealisateur; set => photoRealisateur = value; }
        public string PrenomRealisateur { get => prenomRealisateur; set => prenomRealisateur = value; }
    }
}
