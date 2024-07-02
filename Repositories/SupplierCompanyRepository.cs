using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Models;

namespace Repositories
{
    public class SupplierCompanyRepository
    {
        private AirConditionerShop2023DbContext _context;

        public List<SupplierCompany> GetAllSupplierCompanies()
        {
            _context = new();
            return _context.SupplierCompanies.ToList();
        }
    }
}
