using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal class BusParking : Parking
    {
        #region Fields
        private int _slotId;
        private string _placeName;
        private TimeOnly _arrivalTime;
        private TimeOnly _departureTime;
        #endregion

        #region Properties
        public int SlotId
        {
            get
            {
                return _slotId;
            }

            set
            {
                _slotId = value;
            }
        }

        public string PlaceName
        {
            get
            {
                return _placeName;
            }

            set
            {
                _placeName = value;
            }
        }

        public TimeOnly ArrivalTime
        {
            get
            {
                return _arrivalTime;
            }

            set
            {
                _arrivalTime = value;
            }
        }

        public TimeOnly DepartureTime
        {
            get
            {
                return _departureTime;
            }

            set
            {
                _departureTime = value;
            }
        }

        
        #endregion
        
        public override void Pay()
        {
            throw new NotImplementedException();
        }
    }
}