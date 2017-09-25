using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class FinalDataRes
    {
        public FinalDataMessageRes MESSAGE { get; set; }
    }

    [JsonObject(Title = "DETAIL")]
    public class DETAIL
    {
        public string CUSTOMER_NAME { get; set; }
        public int PID { get; set; }
        public double REVENUE { get; set; }
        public string PID_DESC { get; set; }
        public string MDATE { get; set; }
        public double EBIDTA { get; set; }
    }

    [JsonObject(Title = "FINALDATA")]
    public class FinalDataResult
    {
        public List<DETAIL> DETAILS { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class FinalDataPayloadRes
    {
        public FinalDataResult FINAL_DATA { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class FinalDataSessionRes
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class FinalDataHeaderRes
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class FinalDataMessageRes
    {
        public FinalDataPayloadRes PAYLOAD { get; set; }
        public FinalDataSessionRes SESSION { get; set; }
        public FinalDataHeaderRes HEADER { get; set; }
    }
   
}
