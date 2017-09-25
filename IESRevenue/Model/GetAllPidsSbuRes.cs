using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
   public  class GetAllPidsSbuRes
    {
        public GetAllPidsSbuMessageRes MESSAGE { get; set; }
    }

    [JsonObject(Title = "ALLPIDS")]
    public class ALLPIDS
    {
        public List<object> PIDS { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class GetAllPidsSbuPayloadRes
    {
        public ALLPIDS ALL_PIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class GetAllPidsSbuSessionRes
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class GetAllPidsSbuHeaderRes
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class GetAllPidsSbuMessageRes
    {
        public GetAllPidsSbuPayloadRes PAYLOAD { get; set; }
        public GetAllPidsSbuSessionRes SESSION { get; set; }
        public GetAllPidsSbuHeaderRes HEADER { get; set; }
    }

   
}
