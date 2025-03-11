using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class RessourcesHumaines : IRessourcesHumaines
    {
        // Liste de tout le personnel (étudiants, enseignants, etc.)
        private List<Personnel> GRH = new List<Personnel>();

        // ... autres méthodes et propriétés ...

        public void Afficher_Enseignants()
        {
            foreach (Personnel pers in GRH)
            {
                // Vérifier si cet élément est un enseignant
                if (pers is Enseignant ens)
                {
                    // Parcourir chaque groupe enseigné par cet enseignant
                    foreach (var groupe in ens.Groupes)  // supposons que Enseignant possède une collection Groupes
                    {
                        // Afficher le nom de l’enseignant et le nom du groupe
                        Console.WriteLine($"{ens.Nom} {ens.Prénom} enseigne le groupe {groupe.Nom}");
                    }
                }
            }
        }
    }
}
