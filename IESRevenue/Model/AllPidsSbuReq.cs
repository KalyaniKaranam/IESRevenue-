using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
   public  class AllPidsSbuReq
    {
        public AllpidSbuMessageReq MESSAGE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class AllpidSbuHeaderReq
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "ALLPIDS")]
    public class AllPidSbu
    {
        public string IBU_ID { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class AllpidSbuPayloadReq
    {
        public AllPidSbu ALL_PIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class AllpidSbuSessionReq
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
    public class AllpidSbuMessageReq
    {
        public AllpidSbuHeaderReq HEADER { get; set; }
        public AllpidSbuPayloadReq PAYLOAD { get; set; }
        public AllpidSbuSessionReq SESSION { get; set; }
    }

    
}
