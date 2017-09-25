using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class FinalServiceReq
    {
        public GetFinalMessageReq MESSAGE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetFinalHeaderReq
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "FINALDATA")]
    public class FINALDATAREQ
    {
        public string PID { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class GetFinalPayloadReq
    {
        public FINALDATAREQ FINAL_DATA { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetFinalSessionReq
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
    public class GetFinalMessageReq
    {
        public GetFinalHeaderReq HEADER { get; set; }
        public GetFinalPayloadReq PAYLOAD { get; set; }
        public GetFinalSessionReq SESSION { get; set; }
    }

}
