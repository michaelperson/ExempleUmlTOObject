using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleUmlTOObject
{
    internal class Professor : Person
    {
        public long Salary { get; set; }

        public  override double PurchaseParkingPass(int duree)
        {
            return 0;
        }
    }
}
