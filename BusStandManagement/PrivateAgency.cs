using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusStandManagement
{
    internal class PrivateAgency : TravelAgency
    {

        #region Fields
        private int _inchargeId;
        private string _inchargeContact;
        #endregion
        #region Properties
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

        public string InchargeContact
        {
            get
            {
                return _inchargeContact;
            }

            set
            {
                _inchargeContact = value;
            }
        }
        #endregion

        public virtual string BookTicket()
        {
            //1 je récupère ce que fait le parent
            string infoParent = base.BookTicket();
            return infoParent + " et je rajoute 10% ";
        }
    }
}