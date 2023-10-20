using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal class VehiculeParking : Parking
    {
        #region Fields
        private int _parkingId;
        private string _ownerName;
        private string _vehiculeType;
        private string _vehiculeNumber;
        private TimeOnly _startTime;
        private TimeOnly _endTime;
        #endregion

        #region Properties
        public int ParkingId
        {
            get
            {
                return _parkingId;
            }

            set
            {
                _parkingId = value;
            }
        }

        public string OwnerName
        {
            get
            {
                return _ownerName;
            }

            set
            {
                _ownerName = value;
            }
        }

        public TimeOnly StartTime
        {
            get
            {
                return _startTime;
            }

            set
            {
                _startTime = value;
            }
        }

        public TimeOnly EndTime
        {
            get
            {
                return _endTime;
            }

            set
            {
                _endTime = value;
            }
        }

        public string VehiculeType
        {
            get
            {
                return _vehiculeType;
            }

            set
            {
                _vehiculeType = value;
            }
        }

        public string VehiculeNumber
        {
            get
            {
                return _vehiculeNumber;
            }

            set
            {
                _vehiculeNumber = value;
            }
        }
        #endregion

        public override void Pay()
        {
            throw new NotImplementedException();
        }
    }
}