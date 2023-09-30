using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staff.core
{
    internal interface InterfaceStaff
    {
        // returnType nameOfMethod paramters
        List<staffObj> GetStaffs(); //method: list of staff 
        staffObj GetStaff(int id);//methode: get staff
        staffObj AddStaff(staffObj staff);// method: add staff  
        staffObj UpdateStaff(int id, staffObj staff);//method: update staff 

        staffObj DeleteStaff(int id);// delete staff



    }
}
