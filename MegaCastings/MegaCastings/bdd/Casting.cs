using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastings.bdd
{
    class Casting
    {
        public string intitule { get; set; }
        public DateTime DateDebutPublication { get; set; }
        public int DureeDiffusion { get; set; }
        public DateTime DateDebutContrat { get; set; }
        public string Localisation { get; set; }
        public string DescriptionPoste { get; set; }
        public string DescriptionProfil { get; set; }
        public string Coordonnees { get; set; }
        public int ClientId { get; set; }
        public int MetierId { get; set; }
        public int TypeContratId { get; set; }

        //Constructeur
        public Casting()
        {

        }
    }
}
