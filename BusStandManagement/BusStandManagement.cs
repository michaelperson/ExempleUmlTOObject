using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal class BusStandManagement
    {
        #region Fields
        private string _busStandName;
        private string _city;
        private string _area;


        //Agrégation
        private List<Parking> _parkings;
        private List<Shops> _shops;
        private List<TravelAgency> _travelAgencies;

        #endregion
        #region Properties
        public string BusStandName
        {
            get
            {
                return _busStandName;
            }

            set
            {
                _busStandName = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string Area
        {
            get
            {
                return _area;
            }

            set
            {
                _area = value;
            }
        }

        //Aggregation
        internal List<Parking> Parkings
        {
            get
            {
                return _parkings;
            }

            set
            {
                _parkings = value;
            }
        }

        internal List<Shops> Shops
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

        internal List<TravelAgency> TravelAgencies
        {
            get
            {
                return _travelAgencies;
            }

            set
            {
                _travelAgencies = value;
            }
        }

        
        #endregion

        #region Methods

        public bool IsOpen()
        {
            return true;
        } 
        #endregion

    }
}