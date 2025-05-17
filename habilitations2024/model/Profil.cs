using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Profil
    {
        // declaration des propriété de la class qui correspondant aux champs de la table profil de la base de donnée H
        //et metre la getter en meme temps, pas besoin de déclaration classic
        public int Idprofil { get; }
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idprofil"></param>
        /// <param name="nom"></param>
        
        //constructeur de la class pour initialisation des propriétés
        public Profil(int idprofil, string nom)
        {
            this.Idprofil = idprofil;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du profil</returns>
        // methode tostring pour return nom 
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
