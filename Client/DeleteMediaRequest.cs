using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited.Vidly
{
    [XmlRoot("Query")]
    public class DeleteMediaRequest : VidlyRequest, IXmlSerializable
    {
        private List<string> _mediaShortLinks;
        private int _batchID;

        public DeleteMediaRequest()
            : base("DeleteMedia")
        {
            this._mediaShortLinks = new List<string>();
        }

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

        public int BatchID
        {
            get
            {
                return this._batchID;
            }
            set
            {
                this._batchID = value;
            }
        }

        #region IXmlSerializable Members

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("Action", this.Action);
            writer.WriteElementString("UserID", this.UserId);
            writer.WriteElementString("UserKey", this.UserKey);

            if (!string.IsNullOrEmpty(this.Notify))
            {
                writer.WriteElementString("Notify", this.Notify);
            }
            
            if (this.BatchID > 0)
            {
                writer.WriteElementString("BatchID", this.BatchID.ToString());
            }
            else
            {
                for (int i = 0; i < this.MediaShortLinks.Count; i++)
                {
                    writer.WriteElementString("MediaShortLink", this.MediaShortLinks[i]);
                }
            }
        }

        #endregion
    }
}
