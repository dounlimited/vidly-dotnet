using System;
using System.Xml;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Error")]
    public class MediaError : IXmlSerializable
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

        #region IXmlSerializable Members

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            //if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Errors")
            //{
            //    if (reader.ReadToDescendant("Error"))
            //    {
            //        while (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Error")
            //        {
            //            //reader.MoveToElement();
            //            //Console.WriteLine(reader.Name);
            //            reader.ReadToDescendant("ErrorCode");
                        

            //            //if (reader.Name == "ErrorCode")
            //            //{
            //                this.ErrorCode = reader.ReadElementContentAsDecimal();
            //                Console.WriteLine(this.ErrorCode);

            //                reader.ReadToDescendant("Description");
            //                this.Description = reader.ReadElementContentAsString();
            //                Console.WriteLine(this.Description);

            //                reader.ReadToDescendant("Suggestion");
            //                this.Suggestion = reader.ReadElementContentAsString();
            //                Console.WriteLine(this.Suggestion);
            //            //}
            //            //this.SourceFile = reader.ReadElementContentAsString("SourceFile", string.Empty);
            //            //this.ErrorCode = reader.ReadElementContentAsDecimal("ErrorCode", null);

            //            reader.Read();
            //        }
            //    }
            //    reader.Read();
            //}
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
