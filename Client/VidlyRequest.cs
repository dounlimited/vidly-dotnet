using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DoUnlimited
{
    public abstract class VidlyRequest
    {
        private string _action;
        private string _userId;
        private string _userKey;
        private string _notify;

        internal VidlyRequest(string action)
        {
            this.Action = action;
        }

        [XmlElement("Action")]
        public string Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
            }
        }

        [XmlElement("UserID")]
        public string UserId
        {
            get
            {
                return this._userId;
            }
            set
            {
                this._userId = value;
            }
        }

        [XmlElement("UserKey")]
        public string UserKey
        {
            get
            {
                return this._userKey;
            }
            set
            {
                this._userKey = value;
            }
        }

        [XmlElement("Notify")]
        public string Notify
        {
            get
            {
                return this._notify;
            }
            set
            {
                this._notify = value;
            }
        }

        public string ToXml(Type request)
        {
            StringBuilder sb = new StringBuilder();
            XmlSerializer serial = new XmlSerializer(request);
            XmlWriter xw = XmlWriter.Create(sb);
            serial.Serialize(xw, this);
            return sb.ToString();
        }
    }
}
