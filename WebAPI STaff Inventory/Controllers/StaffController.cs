using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using staff.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_STaff_Inventory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : ControllerBase
    {
        private InterfaceStaff _staffservce;

        public StaffController(InterfaceStaff StaffService)
        {
            _staffservce = StaffService;
        }
        // crud /add,git,update,delete
        [HttpGet]
        public IActionResult GetStaffs()
        {
            return Ok(_staffservce.GetStaffs());
        }

        [HttpPost]

        public IActionResult AddStaff(staffObj staff) 
        {
            return Ok(_staffservce.AddStaff(staff));
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStaff(int id, staffObj staff) 
        {
            return Ok(_staffservce.UpdateStaff(id, staff));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id) 
        {
            return Ok(_staffservce.DeleteStaff(id));
        }
    }
       

   
}
