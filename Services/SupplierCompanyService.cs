using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Models;

namespace Services
{
    public class SupplierCompanyService
    {
        private SupplierCompanyRepository _repo = new();

        public List<SupplierCompany> GetAllSupplierCompany()
            => _repo.GetAllSupplierCompanies();
    }
}
