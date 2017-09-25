namespace IESRevenue.Model.FunctionalUnitInfo
{
    public class FunctionalUnitResponse
    {
        public class ROLEIDSDATA
        {
            public string ID { get; set; }
        }

        public class PAYLOAD
        {
            public ROLEIDSDATA ROLE_IDS_DATA { get; set; }
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
