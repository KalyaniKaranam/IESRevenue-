using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    class GetPidResObj
    {
        public GetPidObjMessageRes MESSAGE { get; set; }
    }

    [JsonObject(Title = "GETPIDS")]
    public class GetPidObj
    {
        public int PIDS { get; set; }
    }


    [JsonObject(Title = "PAYLOAD")]
    public class GetPidObjPayloadRes
    {
        public GetPidObj GET_PIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetPidObjSessionRes
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetPidObjHeaderRes
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class GetPidObjMessageRes
    {
        public GetPidObjPayloadRes PAYLOAD { get; set; }
        public GetPidObjSessionRes SESSION { get; set; }
        public GetPidObjHeaderRes HEADER { get; set; }
    }

   
}
