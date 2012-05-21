using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Response")]
    public class DeleteMediaResponse
    {
        private string _message;
        private decimal _messageCode;
        private List<string> _mediaShortLinks;
        private List<MediaError> _errors;

        public DeleteMediaResponse()
        {
            this._mediaShortLinks = new List<string>();
            this._errors = new List<MediaError>();
        }

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
        //TODO need Success parent element to MSLs
        [XmlElement("MediaShortLink")]
        public List<string> MediaShortLinks
        {
            get
            {
                return this._mediaShortLinks;
            }
            set
            {
                this._mediaShortLinks = value;
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

        public static DeleteMediaResponse Create(XmlDocument xmlDoc)
        {
            DeleteMediaResponse response = new DeleteMediaResponse();
            //TODO fill in the DeleteMediaResponse object with xmlDoc contents.
            return response;
        }
    }
}
