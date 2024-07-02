using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Models;

namespace Services
{
    public class StaffMemberService
    {
        private StaffMemberRepository _repo = new();

        public StaffMember CheckLogin(string email, string password)
            => _repo.GetStaffMember(email, password);
    }
}
