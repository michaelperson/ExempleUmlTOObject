using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleUmlTOObject
{
    internal class Student: Person
    {
        //Propriétés ~= Atributs
        public int StudentNumber { get; set; }
        public double AverageMark {  get; set; }


        //Méthode

        public override double PurchaseParkingPass(int duree)
        {
            double lePrixDeBase = duree * FORFAIT;
            return lePrixDeBase * 1.10;
        }

        public bool IsEligibleToEnroll()
        {
            return AverageMark > 60;
        }

        public string GetSeminarsTaken (DateTime dateDeRecherche)
        {
            return "Aucun";
        }
    }
}
