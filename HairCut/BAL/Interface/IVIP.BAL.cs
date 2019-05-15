using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface
{
    public interface IVIPBAL
    {
        DataTable GetAllVIP();
        bool SaveVIP(DataTable dataTable);
        DataTable GetVIPByNo(string VIPNo);
    }
}
