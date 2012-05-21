using System;
using System.Xml.Serialization;

namespace DoUnlimited.Vidly
{
    public class MediaSource
    {
        private string _sourceFile;
        private string _cdn;
        private object _format;

        public MediaSource()
        {
        }

        public MediaSource(string sourceFile)
        {
            this.SourceFile = sourceFile;
        }

        public MediaSource(string sourceFile, string cdn)
        {
            this.SourceFile = sourceFile;
            this.CDN = cdn;
        }

        public MediaSource(string sourceFile, string cdn, object format)
        {
            this.SourceFile = sourceFile;
            this.CDN = cdn;
            this.Format = format;
        }

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

        [XmlElement("CDN")]
        public string CDN
        {
            get
            {
                return this._cdn;
            }
            set
            {
                this._cdn = value;
            }
        }

        [XmlElement("Format")]
        public object Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }
    }
}
