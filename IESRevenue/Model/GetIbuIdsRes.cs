using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class GetIbuIdsRes
    {
        public GetIbuIdsMessage MESSAGE { get; set; }
    }

    [JsonObject(Title = "GETIBUIDS")]
    public class GETIBUIDSRES
    {
        public List<string> IBU_ID { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class GetIbuIdsPayload
    {
        public GETIBUIDSRES GET_IBUIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetIbuIdsSession
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetIbuIdsHeader
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class GetIbuIdsMessage
    {
        public GetIbuIdsPayload PAYLOAD { get; set; }
        public GetIbuIdsSession SESSION { get; set; }
        public GetIbuIdsHeader HEADER { get; set; }
    }

    
}
