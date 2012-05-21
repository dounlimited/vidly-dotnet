using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited
{
    public class UpdateMediaSource : MediaSource
    {
        private string _vanityLink;
        //TODO add new MediaProtect class and property

        public UpdateMediaSource()
            : base()
        {
        }

        [XmlElement("VanityLink")]
        public string VanityLink
        {
            get
            {
                return this._vanityLink;
            }
            set
            {
                this._vanityLink = value;
            }
        }
    }
}
