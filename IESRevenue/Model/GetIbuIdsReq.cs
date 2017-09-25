using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class GetIbuIdsReq
    {
        public GetIbuIdMessage MESSAGE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetIbuIdHeader
    {
        public string LOGIN { get; set; }
    }

    
    public class GETIBUIDS
    {
        public string IBG_ID { get; set; }
        public string LAN_ID { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class GetIbuIdPayload
    {
        public GETIBUIDS GET_IBUIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetIbuIdSession
    {
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }
        public string APP { get; set; }
        public string ORG { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public string TYPE { get; set; }
        public string CHANNEL { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class GetIbuIdMessage
    {
        public GetIbuIdHeader HEADER { get; set; }
        public GetIbuIdPayload PAYLOAD { get; set; }
        public GetIbuIdSession SESSION { get; set; }
    }

    
}
