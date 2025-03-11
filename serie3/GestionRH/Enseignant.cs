using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Enseignant : Personnel
    {
        private string grade;
        private float vh;
        private float nbr_hr_sup;
        private Dictionary<string, List<Etudiant>> Grp;

        public Enseignant (string bureau, double salaire, double prime, int code, string nom, string prenom, string grade, float vh, float nbr_hr_sup) : base(bureau, salaire, prime, code, nom, prenom)
        {
            this.grade = grade;
            this.vh = VH;
            this.nbr_hr_sup = nbr_hr_sup;
        }
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public float Vh
        {
            get { return vh; }
            set { vh = value; }
        }
        public float Nbr_hr_sup
        {
            get { return nbr_hr_sup; }
            set { nbr_hr_sup = value; }
        }

        public void Ajouter_groupe(Groupe grp )
        {

        }


    }
}
