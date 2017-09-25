using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESRevenue.Controls
{
    public class DropDownTapArgs
    {
        public DropDownTapArgs(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public float X { get; set; }

        public float Y { get; set; }
    }
}
