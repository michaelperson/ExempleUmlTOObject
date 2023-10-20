using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal class Shops
    {
        #region Properties
        private int _shopId;
        private string _shopName;
        private int _ownerId;
        #endregion

        #region Properties
        public int ShopId
        {
            get
            {
                return _shopId;
            }

            set
            {
                _shopId = value;
            }
        }

        public string ShopName
        {
            get
            {
                return _shopName;
            }

            set
            {
                _shopName = value;
            }
        }

        public int OwnerId
        {
            get
            {
                return _ownerId;
            }

            set
            {
                _ownerId = value;
            }
        } 
        #endregion


        public string ShopDetails()
        {
            return ShopName;
        }

        public double Buy()
        {
            return 0;
        }
    }
}