using System;
using System.Xml.Serialization;

namespace DoUnlimited.Vidly
{
    public class MediaShortLink
    {
        private string _sourceFile;
        private string _shortLink;

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

        [XmlElement("ShortLink")]
        public string ShortLink
        {
            get
            {
                return this._shortLink;
            }
            set
            {
                this._shortLink = value;
            }
        }
    }
}
