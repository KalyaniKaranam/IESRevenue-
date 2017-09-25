using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class SbuAllIbuRes
    {
        public SbuAllIbuMessageRes MESSAGE { get; set; }
    }

    [JsonObject(Title = "ALLIBUIDS")]
    public class GETALLIBUIDS
    {
        public List<string> IBU_ID { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class SbuAllIbuPayloadRes
    {
        public GETALLIBUIDS ALL_IBUIDS { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class SbuAllIbuSessionRes
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class SbuAllIbuHeaderRes
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class SbuAllIbuMessageRes
    {
        public SbuAllIbuPayloadRes PAYLOAD { get; set; }
        public SbuAllIbuSessionRes SESSION { get; set; }
        public SbuAllIbuHeaderRes HEADER { get; set; }
    }

   
}
