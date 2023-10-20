using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal class GovernementAgency : TravelAgency
    {
        private int _inchargeId;

        public int InchargeId
        {
            get
            {
                return _inchargeId;
            }

            set
            {
                _inchargeId = value;
            }
        }
    }
}