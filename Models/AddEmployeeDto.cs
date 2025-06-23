using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddEmployeeDto : ControllerBase
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Salary { get; set; }
    }
}
