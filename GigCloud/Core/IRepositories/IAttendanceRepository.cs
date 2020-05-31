using System.Collections.Generic;
using GigCloud.Core.Models;

namespace GigCloud.Core.IRepositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetFutureAttendances(string userId);
        Attendance GetAttendance(int gigId, string userId);
    }
}