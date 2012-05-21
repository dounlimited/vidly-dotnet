using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DoUnlimited
{
    [XmlRoot("Query")]
    public class StatusMediaRequest : DeleteMediaRequest
    {
        public StatusMediaRequest()
            : base()
        {
            this.Action = "GetStatus";
        }
    }
}
