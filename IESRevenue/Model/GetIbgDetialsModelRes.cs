using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class GetIbgDetialsModelRes
    {
        public GetIbgMessage MESSAGE { get; set; }
    }

    [JsonObject(Title = "IBGIDDATA")]
    public class GetIbgIdData
    {
        public List<string> IBG_ID { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class IbgPayload
    {
        public GetIbgIdData IBGID_DATA { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetIbgSession
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetIbgHeader
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class GetIbgMessage
    {
        public IbgPayload PAYLOAD { get; set; }
        public GetIbgSession SESSION { get; set; }
        public GetIbgHeader HEADER { get; set; }
    }

   
}
