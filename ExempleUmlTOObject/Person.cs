using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleUmlTOObject
{
    internal abstract class Person
    {

        protected const int FORFAIT = 3;
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string EmailAdress { get; set; }

        public Address Adresse
        {
            get;

            set;
        }

        public abstract double PurchaseParkingPass(int duree);
        //{
        //    return duree * 3;
        //}
        
    }
}
