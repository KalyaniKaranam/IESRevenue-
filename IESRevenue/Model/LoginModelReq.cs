using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
   public class LoginModelReq
    {
        public MESSAGE MESSAGE { get; set; }
    }
    public class HEADER
    {
        public string LOGIN { get; set; }
    }

    public class ROLEDATA
    {
        public string LAN_ID { get; set; }
    }

    public class PAYLOAD
    {
        public ROLEDATA ROLE_DATA { get; set; }
    }

    public class SESSION
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

    public class MESSAGE
    {
        public HEADER HEADER { get; set; }
        public PAYLOAD PAYLOAD { get; set; }
        public SESSION SESSION { get; set; }
    }
}
