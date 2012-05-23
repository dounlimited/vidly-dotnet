using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace DoUnlimited.Vidly
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
            response.Message = xmlDoc.DocumentElement.SelectSingleNode("Message").InnerText;
            response.MessageCode = decimal.Parse(xmlDoc.DocumentElement.SelectSingleNode("MessageCode").InnerText);

            XmlNodeList successNodes = xmlDoc.DocumentElement.SelectNodes("Success/Task");

            for (int i = 0; i < successNodes.Count; i++)
            {
                XmlNode successNode = successNodes[i];
                MediaStatus status = new MediaStatus();

                status.UserID = successNode.SelectSingleNode("UserID").InnerText;
                status.MediaShortLink = successNode.SelectSingleNode("MediaShortLink").InnerText;
                status.SourceFile = successNode.SelectSingleNode("SourceFile").InnerText;
                status.Status = successNode.SelectSingleNode("Status").InnerText;
                status.Created = DateTime.Parse(successNode.SelectSingleNode("Created").InnerText);
                status.Updated = DateTime.Parse(successNode.SelectSingleNode("Updated").InnerText);
                status.UserEmail = successNode.SelectSingleNode("UserEmail").InnerText;

                XmlNode batchNode = successNode.SelectSingleNode("BatchID");
                if (!string.IsNullOrEmpty(batchNode.InnerText))
                {
                    status.BatchID = int.Parse(batchNode.InnerText);
                }

                response.MediaStatus.Add(status);
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
