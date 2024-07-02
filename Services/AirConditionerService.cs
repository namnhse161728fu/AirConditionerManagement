using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Models;

namespace Services
{
    public class AirConditionerService
    {
        private AirConditionerRepository _repo = new();
        
        public List<AirConditioner> GetAllAirConditioners()
            => _repo.GetAllAirConditioners();

        public void DeleteAirConditioner(AirConditioner airConditioner)
            => _repo.DeleteAirConditioner(airConditioner);

        public AirConditioner GetAirConditioner(int id)
            => _repo.GetAirConditioner(id);

        public void CreateAirConditioner(AirConditioner airConditioner)
            => _repo.CreateAirConditioner(airConditioner);

        public void UpdateAirConditioner(AirConditioner airConditioner)
            => _repo.UpdateAirConditioner(airConditioner);
    }
}
