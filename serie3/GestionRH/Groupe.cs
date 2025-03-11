using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Groupe
    {
        private string nom;
        private List<Etudiant> LE;
        
        public Groupe(string nom)
        {
            this.nom = nom;
            LE = new List<Etudiant>;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public void Ajouter_etudiant(Etudiant etd)
        {
            foreach(Etudiant e in LE)
            {
                
                if (etd.Code = e.Code)
                {
                    Console.WriteLine("Etudiant deja existe dans la liste");
                    return;
                }
               
            }
            LE.Add(etd);
            Console.WriteLine("L'etudiant est ajouter avec succes");
        }

    }
}
