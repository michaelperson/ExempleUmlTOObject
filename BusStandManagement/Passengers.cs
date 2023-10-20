using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal class Passengers
    {

        #region Fields
        private int _passengerId;
        private string _passengerName;
        private int _passengerAge;
        private int _passengerGender;
        private String _source;
        private string _destination;
        private int _busId;
        private Shops _shops;
        #endregion


        #region Properties
        //Association
        public Shops Shop
        {
            get
            {
                return _shops;
            }

            set
            {
                _shops = value;
            }
        }

        public int PassengerId
        {
            get
            {
                return _passengerId;
            }

            set
            {
                _passengerId = value;
            }
        }

        public string PassengerName
        {
            get
            {
                return _passengerName;
            }

            set
            {
                _passengerName = value;
            }
        }

        public int PassengerAge
        {
            get
            {
                return _passengerAge;
            }

            set
            {
                _passengerAge = value;
            }
        }

        public int PassengerGender
        {
            get
            {
                return _passengerGender;
            }

            set
            {
                _passengerGender = value;
            }
        }

        public string Source
        {
            get
            {
                return _source;
            }

            set
            {
                _source = value;
            }
        }

        public string Destination
        {
            get
            {
                return _destination;
            }

            set
            {
                _destination = value;
            }
        }

        public int BusId
        {
            get
            {
                return _busId;
            }

            set
            {
                _busId = value;
            }
        } 
        #endregion
    }
}