using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastings.bdd
{
    class Customer
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public int Nbr_castings { get; set; }

        // Constructeur
        public Customer()
        {
        }
    }
}
