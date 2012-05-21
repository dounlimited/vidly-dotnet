using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DoUnlimited.Vidly
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
            XmlSerializer serial = new XmlSerializer(request);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Encoding = Encoding.UTF8;

            XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);

            XmlWriter xw = XmlWriter.Create(ms, xws);
            serial.Serialize(xw, this, xns);

            xw.Flush();
            xw.Close();
            ms.Position = 0;

            System.IO.StreamReader sr = new System.IO.StreamReader(ms);
            string xml = sr.ReadToEnd();
            ms.Close();
            sr.Close();

            return xml;
        }
    }
}
