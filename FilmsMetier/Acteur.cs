using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsMetier
{
    public class Acteur
    {
        private string nomActeur;
        private string photoActeur;
        private string prenomActeur;

        public Acteur(string unNom, string unPrenom, string unePhoto)
        {
            NomActeur = unNom;
            PhotoActeur = unePhoto;
            PrenomActeur = unPrenom;
        }

        public string NomActeur { get => nomActeur; set => nomActeur = value; }
        public string PhotoActeur { get => photoActeur; set => photoActeur = value; }
        public string PrenomActeur { get => prenomActeur; set => prenomActeur = value; }
    }
}
