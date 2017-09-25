using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    public class GetFinalDataObj
    {
        public FinalDataObjMessage MESSAGE { get; set; }
    }

    [JsonObject(Title = "DETAILS")]
    public class FinalDataObjDetails
    {
        public string CUSTOMER_NAME { get; set; }
        public int PID { get; set; }
        public int REVENUE { get; set; }
        public string PID_DESC { get; set; }
        public string MDATE { get; set; }
        public double EBIDTA { get; set; }
    }

    [JsonObject(Title = "FINALDATA")]
    public class FINALDATA
    {
        public FinalDataObjDetails DETAILS { get; set; }
    }

    [JsonObject(Title = "PAYLOAD")]
    public class FinalDataObjPayload
    {
        public FINALDATA FINAL_DATA { get; set; }
    }

    [JsonObject(Title = "SESSION")]
    public class FinalDataObjSession
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }

    [JsonObject(Title = "HEADER")]
    public class FinalDataObjHeader
    {
        public string LOGIN { get; set; }
    }

    [JsonObject(Title = "MESSAGE")]
    public class FinalDataObjMessage
    {
        public FinalDataObjPayload PAYLOAD { get; set; }
        public FinalDataObjSession SESSION { get; set; }
        public FinalDataObjHeader HEADER { get; set; }
    }
}
