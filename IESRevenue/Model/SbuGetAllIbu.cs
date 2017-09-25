using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class SbuGetAllIbu
    {
        public GetAllIbuMessageReq MESSAGE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetAllIbuHeaderReq
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "ALLIBUIDS")]
    public class ALLIBUIDS
    {
        public string IBG_ID { get; set; }
    }
    [JsonObject(Title = "PAYLOAD")]
    public class GetAllIbuPayloadReq
    {
        public ALLIBUIDS ALL_IBUIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetAllIbuSessionReq
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
    public class GetAllIbuMessageReq
    {
        public GetAllIbuHeaderReq HEADER { get; set; }
        public GetAllIbuPayloadReq PAYLOAD { get; set; }
        public GetAllIbuSessionReq SESSION { get; set; }
    }
}
