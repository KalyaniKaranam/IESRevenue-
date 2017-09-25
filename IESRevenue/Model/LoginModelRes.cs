using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    //[JsonObject(Title = "Details")]
    public class DETAILS
    {       
        public string ROLE { get; set; }
    }
    [JsonObject(Title = "ROLEDATA")]
    public class Roledatas
    {
        public DETAILS DETAILS { get; set; }
    }
    [JsonObject(Title = "PAYLOAD")]
    public class Pay
    {
        public Roledatas ROLE_DATA { get; set; }
    }
    [JsonObject(Title = "SESSION")]
    public class Sessions
    {
        public string APP { get; set; }
        public string TRANSACTION { get; set; }
        public string KEY { get; set; }
        public int LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public int LATITUDE { get; set; }
    }
    [JsonObject(Title = "HEADER")]
    public class Headers
    {
        public string LOGIN { get; set; }
    }
    [JsonObject(Title = "MESSAGE")]
    public class Messages
    {
        public Pay PAYLOAD { get; set; }
        public Sessions SESSION { get; set; }
        public Headers HEADER { get; set; }
    }

    public class LoginModelRes
    {
        public Messages MESSAGE { get; set; }
    }
}
