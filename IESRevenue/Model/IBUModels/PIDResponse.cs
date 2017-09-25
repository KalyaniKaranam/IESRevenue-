using System.Collections.Generic;

namespace IESRevenue.Model.IBUModels
{
    public class PIDResponse
    {
        public class PIDREVENUEEBIDTA
        {
            public string REVENUE { get; set; }
            public string EBIDTA { get; set; }
        }

        public class PAYLOAD
        {
            public PIDREVENUEEBIDTA PID_REVENUE_EBIDTA { get; set; }
        }

        public class SESSION
        {
            public string APP { get; set; }
            public string TRANSACTION { get; set; }
            public string KEY { get; set; }
            public int LONGITUDE { get; set; }
            public string TYPE { get; set; }
            public int LATITUDE { get; set; }
        }

        public class HEADER
        {
            public string LOGIN { get; set; }
        }

        public class MESSAGE
        {
            public PAYLOAD PAYLOAD { get; set; }
            public SESSION SESSION { get; set; }
            public HEADER HEADER { get; set; }
        }

        public class RootObject
        {
            public MESSAGE MESSAGE { get; set; }
        }
    }
}
