namespace IESRevenue.Model.SBU_Models
{
    public class HEADER
    {
        public string LOGIN { get; set; }
    }

    public class SESSION
    {
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }
        public string TYPE { get; set; }
        public string KEY { get; set; }
        public string TRANSACTION { get; set; }
    }

    public class IBGIDREVENUEEBIDTA
    {
        public string EBIDTA { get; set; }
        public string REVENUE { get; set; }
    }

    public class PAYLOAD
    {
        public IBGIDREVENUEEBIDTA IBGID_REVENUE_EBIDTA { get; set; }
    }

    public class MESSAGE
    {
        public HEADER HEADER { get; set; }
        public SESSION SESSION { get; set; }
        public PAYLOAD PAYLOAD { get; set; }
    }

    public class RootObject
    {
        public MESSAGE MESSAGE { get; set; }
    }
}
