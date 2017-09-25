using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
   public class GetIbgDetailsModelReq
    {
        public GetIbgReqMessage MESSAGE { get; set; }
    }
    [JsonObject(Title = "HEADER")]
    public class GetIbgReqHeader
    {
        public string LOGIN { get; set; }
    }
    [JsonObject(Title = "PAYLOAD")]
    public class GetIbgReqPayload
    {
        public string IBGID_DATA { get; set; }
    }
    [JsonObject(Title = "SESSION")]
    public class GetIbgReqSession
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
    public class GetIbgReqMessage
    {
        public GetIbgReqHeader HEADER { get; set; }
        public GetIbgReqPayload PAYLOAD { get; set; }
        public GetIbgReqSession SESSION { get; set; }
    }

   
}
