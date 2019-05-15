using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface
{
    public interface IStaff
    {
        DataTable GetAllStaff();
        bool SaveStaff(DataTable dataTable);
        List<Staff> GetAllStaffList(string typeName);

    }
}
