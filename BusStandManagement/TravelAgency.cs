using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal abstract class TravelAgency
    {
        #region Fields
        private string _agencyName;
        private int _totalBuses;
        #endregion
        #region Properties
        public string AgencyName
        {
            get
            {
                return _agencyName;
            }

            set
            {
                _agencyName = value;
            }
        }

        public int TotalBuses
        {
            get
            {
                return _totalBuses;
            }

            set
            {
                _totalBuses = value;
            }
        }
        #endregion


        #region Methods
        public int GetavailableBusses()
        {
            return _totalBuses;
        }

        public virtual string BookTicket()
        {
            return "Je paye le barême imposé par la loi";
        } 
        #endregion
    }
}