using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
   public  class GetPidReq
    {
        public GetpidMessageReq MESSAGE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetpidHeaderReq
    {
        public string LOGIN { get; set; }
    }

    
    public class GETPIDS
    {
        public string IBU_ID { get; set; }
        public string LAN_ID { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class GetpidPayloadReq
    {
        public GETPIDS GET_PIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetpidSessionReq
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
    public class GetpidMessageReq
    {
        public GetpidHeaderReq HEADER { get; set; }
        public GetpidPayloadReq PAYLOAD { get; set; }
        public GetpidSessionReq SESSION { get; set; }
    }

    
}
