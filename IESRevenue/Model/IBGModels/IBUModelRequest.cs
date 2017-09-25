namespace IESRevenue.Model.IBGModels
{
    public class IBUModelRequest
    {
        public class HEADER
        {
            public string LOGIN { get; set; }
        }

        public class IBUIDREVENUEEBIDTA
        {
            public string LANID { get; set; }
            public string IBUID { get; set; }
            public string FROM_DATE { get; set; }
            public string TO_DATE { get; set; }
            public string REQ_IBGID { get; set; }
        }

        public class PAYLOAD
        {
            public IBUIDREVENUEEBIDTA IBUID_REVENUE_EBIDTA { get; set; }
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

        public class RootObject
        {
            public MESSAGE MESSAGE { get; set; }
        }
    }
}
