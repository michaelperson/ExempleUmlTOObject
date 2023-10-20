using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExempleUmlTOObject
{
    internal class Visiteur : Person
    {
        public override double PurchaseParkingPass(int duree)
        {
            return duree * FORFAIT;
        }
    }
}