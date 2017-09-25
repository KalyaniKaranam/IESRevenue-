using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace IESRevenue.Model
{
   

    public interface ISave
    {
        //Method to save document as a file and view the saved document
        void SaveAndView(string filename, string contentType, MemoryStream stream);
    }
}
