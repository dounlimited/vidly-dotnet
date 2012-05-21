using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Response")]
    public class StatusMediaResponse
    {
        private string _message;
        private decimal _messageCode;
        private List<MediaStatus> _mediaStatus;
        private List<MediaError> _errors;

        public StatusMediaResponse()
        {
            this._mediaStatus = new List<MediaStatus>();
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

        [XmlElement("Success")]
        public List<MediaStatus> MediaStatus
        {
            get
            {
                return this._mediaStatus;
            }
            set
            {
                this._mediaStatus = value;
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

        public static StatusMediaResponse Create(XmlDocument xmlDoc)
        {
            StatusMediaResponse response = new StatusMediaResponse();
            //TODO fill in the StatusMediaResponse object with xmlDoc contents.
            return response;
        }
    }
}
