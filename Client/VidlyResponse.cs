using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DoUnlimited.Vidly
{
    [XmlRoot("Response")]
    public class VidlyResponse
    {
        private string _message;
        private decimal _messageCode;
        private List<MediaShortLink> _success;
        private List<MediaError> _errors;

        public VidlyResponse()
        {
            this._success = new List<MediaShortLink>();
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

        public static VidlyResponse Create(XmlDocument xmlDoc)
        {
            VidlyResponse response = new VidlyResponse();
            response.Message = xmlDoc.DocumentElement.SelectSingleNode("Message").InnerText;
            response.MessageCode = decimal.Parse(xmlDoc.DocumentElement.SelectSingleNode("MessageCode").InnerText);

            XmlNodeList successNodes = xmlDoc.DocumentElement.SelectNodes("Success/MediaShortLink");

            for (int i = 0; i < successNodes.Count; i++)
            {
                XmlNode successNode = successNodes[i];
                MediaShortLink link = new MediaShortLink();

                link.SourceFile = successNode.SelectSingleNode("SourceFile").InnerText;
                link.ShortLink = successNode.SelectSingleNode("ShortLink").InnerText;
                response.Success.Add(link);
            }

            XmlNodeList errorNodes = xmlDoc.DocumentElement.SelectNodes("Errors/Error");

            for (int i = 0; i < errorNodes.Count; i++)
            {
                XmlNode errorNode = errorNodes[i];
                MediaError error = new MediaError();

                XmlNode sourceFileNode = errorNode.SelectSingleNode("SourceFile");
                if (sourceFileNode != null)
                {
                    error.SourceFile = errorNode.SelectSingleNode("SourceFile").InnerText;
                }
                error.ErrorCode = decimal.Parse(errorNode.SelectSingleNode("ErrorCode").InnerText);
                error.Description = errorNode.SelectSingleNode("Description").InnerText;
                error.Suggestion = errorNode.SelectSingleNode("Suggestion").InnerText;
                response.Errors.Add(error);
            }

            return response;
        }
    }
}
