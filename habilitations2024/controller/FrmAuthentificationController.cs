using habilitations2024.dal;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.controller
{
    public class FrmAuthentificationController
    {
        // objet d'accès aux opérations possibles sur Developpeur
        private readonly DeveloppeurAccess developpeurAccess;

        //la constructeur da la class
        public FrmAuthentificationController()
        {
            developpeurAccess= new DeveloppeurAccess();
        }

        // appel de la method boolean "ControleAuthentification"
        public Boolean ControleAuthentification(Admin admin)
        {
            return developpeurAccess.ControleAuthentification(admin);
        }



    }
}
