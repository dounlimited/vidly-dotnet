using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Query")]
    public class UpdateMediaRequest : AddMediaRequest
    {
        private List<UpdateMediaSource> _sources;

        public UpdateMediaRequest()
        {
            this.Action = "UpdateMedia";

            this._sources = new List<UpdateMediaSource>();
        }

        [XmlElement("Source")]
        public new List<UpdateMediaSource> Sources
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
