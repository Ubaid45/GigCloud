using GigCloud.Models;
using Microsoft.AspNet.Identity;
using System.Web.Http;

namespace GigCloud.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] int gigId)
        {
            var userId = User.Identity.GetUserId();

            var attendance = new Attendance
            {
                GigId = gigId,
                AttendeeId = userId
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
