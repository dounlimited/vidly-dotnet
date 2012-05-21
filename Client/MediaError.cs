using System;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Error")]
    public class MediaError
    {
        private string _sourceFile;
        private decimal _errorCode;
        private string _description;
        private string _suggestion;

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

        [XmlElement("ErrorCode")]
        public decimal ErrorCode
        {
            get
            {
                return this._errorCode;
            }
            set
            {
                this._errorCode = value;
            }
        }

        [XmlElement("Description")]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        [XmlElement("Suggestion")]
        public string Suggestion
        {
            get
            {
                return this._suggestion;
            }
            set
            {
                this._suggestion = value;
            }
        }
    }
}
