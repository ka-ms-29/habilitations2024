using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace habilitations2024.model
{
    public class Admin
    {
        public string Nom { get; }
        public string Prenom { get; }
        public string Pwd { get; }

        public Admin(string nom, String prenom, string pwd)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Pwd = pwd;        
        }
    }
    
}
