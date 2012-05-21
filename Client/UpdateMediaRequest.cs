using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Query")]
    public class UpdateMediaRequest : VidlyRequest
    {
        private List<UpdateMediaSource> _sources;

        public UpdateMediaRequest() 
            : base("UpdateMedia")
        {
            this._sources = new List<UpdateMediaSource>();
        }

        [XmlElement("Source")]
        public List<UpdateMediaSource> Sources
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
