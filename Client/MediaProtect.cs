using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited.Vidly
{
    public class MediaProtect
    {
        //TODO serialize these dates in the expected format.
        private DateTime _startDate;
        private DateTime _expirationDate;
        private string _ipAddress;
        private string _token;

        public MediaProtect()
        {
        }

        [XmlElement("StartDate")]
        public DateTime StartDate
        {
            get
            {
                return this._startDate;
            }
            set
            {
                this._startDate = value;
            }
        }

        [XmlElement("ExpirationDate")]
        public DateTime ExpirationDate
        {
            get
            {
                return this._expirationDate;
            }
            set
            {
                this._expirationDate = value;
            }
        }

        [XmlElement("IpAddress")]
        public string IpAddress
        {
            get
            {
                return this._ipAddress;
            }
            set
            {
                this._ipAddress = value;
            }
        }

        [XmlElement("Token")]
        public string Token
        {
            get
            {
                return this._token;
            }
            set
            {
                this._token = value;
            }
        }
    }
}
