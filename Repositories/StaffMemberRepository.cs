using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Models;

namespace Repositories
{
    public class StaffMemberRepository
    {
        private AirConditionerShop2023DbContext _context;

        public StaffMember GetStaffMember(string email, string password)
        {
            _context = new();
            return _context.StaffMembers.FirstOrDefault(s => s.EmailAddress == email && s.Password == password);
        }
    }
}
