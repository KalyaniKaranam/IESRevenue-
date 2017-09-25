using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Model
{
    class SBUModel
    {
        public string  SbuName { get; set; }
        public List<string> SbuId { get; set; }
        public List<string> IbgId { get; set; }
        public List<string> IbuId { get; set; }
        public List<string> PId { get; set; }
    }
}
