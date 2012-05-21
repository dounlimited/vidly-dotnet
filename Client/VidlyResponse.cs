using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Response")]
    public class VidlyResponse
    {
        private string _message;
        private decimal _messageCode;
        private List<MediaShortLink> _success;
        private List<MediaError> _errors;

        [XmlElement("Message")]
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                this._message = value;
            }
        }

        [XmlElement("MessageCode")]
        public decimal MessageCode
        {
            get
            {
                return this._messageCode;
            }
            set
            {
                this._messageCode = value;
            }
        }

        [XmlElement("Success")]
        public List<MediaShortLink> Success
        {
            get
            {
                return this._success;
            }
            set
            {
                this._success = value;
            }
        }

        [XmlElement("Errors")]
        public List<MediaError> Errors
        {
            get
            {
                return this._errors;
            }
            set
            {
                this._errors = value;
            }
        }

        public static VidlyResponse Create(string xml)
        {
            StringReader sr = new StringReader(xml);            
            XmlSerializer serial = new XmlSerializer(typeof(VidlyResponse));
            XmlReader xr = XmlReader.Create(sr);
            VidlyResponse response = (VidlyResponse)serial.Deserialize(xr);
            return response;
        }

        public static VidlyResponse Create(XmlDocument xmlDoc)
        {
            VidlyResponse response = new VidlyResponse();
            //TODO fill in the VidlyResponse object with xmlDoc contents.
            return response;
        }
    }
}
