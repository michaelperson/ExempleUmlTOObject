using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal abstract class Parking
    {
        

        #region Methods
        public bool ParkVehicle()
        {
            return true;
        }

        public abstract void Pay();
        #endregion

    }
}