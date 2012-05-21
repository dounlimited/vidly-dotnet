using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited
{
    public class UpdateMediaSource : MediaSource
    {
        private string _mediaShortLink;
        private string _vanityLink;
        private MediaProtect _protect;

        public UpdateMediaSource()
            : base()
        {
        }

        [XmlElement("MediaShortLink")]
        public string MediaShortLink
        {
            get
            {
                return this._mediaShortLink;
            }
            set
            {
                this._mediaShortLink = value;
            }
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

        [XmlElement("Protect")]
        public MediaProtect Protect
        {
            get
            {
                return this._protect;
            }
            set
            {
                this._protect = value;
            }
        }
    }
}
