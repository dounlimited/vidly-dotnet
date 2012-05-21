using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Task")]
    public class MediaStatus
    {
        private string _userID;
        private string _mediaShortLink;
        private string _sourceFile;
        private int _batchID;
        private string _status;
        private DateTime _created;
        private DateTime _updated;
        private string _userEmail;

        public MediaStatus()
        {
        }

        [XmlElement("UserID")]
        public string UserID
        {
            get
            {
                return this._userID;
            }
            set
            {
                this._userID = value;
            }
        }

        [XmlElement("MediaShortLink")]
        public string MediaShortLink
        {
            get
            {
                return this._mediaShortLink;
            }
            set
            {
                this._mediaShortLink = value;
            }
        }

        [XmlElement("SourceFile")]
        public string SourceFile
        {
            get
            {
                return this._sourceFile;
            }
            set
            {
                this._sourceFile = value;
            }
        }

        [XmlElement("BatchID")]
        public int BatchID
        {
            get
            {
                return this._batchID;
            }
            set
            {
                this._batchID = value;
            }
        }

        [XmlElement("Status")]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }

        [XmlElement("Created")]
        public DateTime Created
        {
            get
            {
                return this._created;
            }
            set
            {
                this._created = value;
            }
        }

        [XmlElement("Updated")]
        public DateTime Updated
        {
            get
            {
                return this._updated;
            }
            set
            {
                this._updated = value;
            }
        }

        [XmlElement("UserEmail")]
        public string UserEmail
        {
            get
            {
                return this._userEmail;
            }
            set
            {
                this._userEmail = value;
            }
        }
    }
}
