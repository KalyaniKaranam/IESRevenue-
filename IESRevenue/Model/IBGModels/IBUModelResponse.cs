using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model.IBGModels
{
    public class IBUModelResponse
    {
        public class IBUIDREVENUEEBIDTA
        {
            public string REVENUE { get; set; }
            public string EBIDTA { get; set; }
        }

        public class PAYLOAD
        {
            public IBUIDREVENUEEBIDTA IBUID_REVENUE_EBIDTA { get; set; }
        }

        public class SESSION
        {
            public string APP { get; set; }
            public string TRANSACTION { get; set; }
            public string KEY { get; set; }
            public string LONGITUDE { get; set; }
            public string TYPE { get; set; }
            public string LATITUDE { get; set; }
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
