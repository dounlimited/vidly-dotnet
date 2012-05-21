using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited.Vidly
{
    [XmlRoot("Query")]
    public class AddMediaRequest : VidlyRequest
    {
        private List<MediaSource> _sources;

        public AddMediaRequest()
            : base("AddMedia")
        {
            this._sources = new List<MediaSource>();
        }

        public AddMediaRequest(string action)
            : base(action)
        {
            this._sources = new List<MediaSource>();
        }

        [XmlElement("Source")]
        public List<MediaSource> Sources
        {
            get
            {
                return this._sources;
            }
            set
            {
                this._sources = value;
            }
        }
    }
}
