using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace staff.core
{
    public class StaffService : InterfaceStaff
    {
        //list to store staff
        private List<staffObj> _staffs;
        //counter for staff id 
        private int _NextId = 1;
        
        // create constructor [a sample of staff to place into list of staff]

        public StaffService() 
        {
            _staffs = new List<staffObj>
            {
                new staffObj
                {
                    staffId = _NextId ++,
                    Firstname = "ibrahim",
                    Lastname = "kedir",
                    Level = 1
                }
            };
        }
        public staffObj AddStaff(staffObj staff)
        {
            staff.staffId = _NextId++;
            _staffs.Add(staff);
            return staff;
        }

        public staffObj DeleteStaff(int id)
        {
            throw new NotImplementedException();
        }

        public staffObj GetStaff(int id)
        {
            return _staffs.FirstOrDefault(staff => staff.staffId == id);
        }

        public List<staffObj> GetStaffs()
        {
            return _staffs;
        }

        public staffObj UpdateStaff(int id, staffObj staff)
        {
            throw new NotImplementedException();
        }
    }
}
