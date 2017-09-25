using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class GetPidResponse
    {
        public GetPidMessageRes MESSAGE { get; set; }
    }

    [JsonObject(Title = "GETPIDS")]
    public class GetPidsRes
    {
        public List<object> PIDS { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class GetPidPayloadRes
    {
        public GetPidsRes GET_PIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetPidSessionRes
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetPidHeaderRes
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class GetPidMessageRes
    {
        public GetPidPayloadRes PAYLOAD { get; set; }
        public GetPidSessionRes SESSION { get; set; }
        public GetPidHeaderRes HEADER { get; set; }
    }

   
}
