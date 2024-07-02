using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Repositories.Models;

namespace Repositories
{
    public class AirConditionerRepository
    {
        private AirConditionerShop2023DbContext _context;

        public List<AirConditioner> GetAllAirConditioners()
        {
            _context = new();
            return _context.AirConditioners.ToList();
        }

        public void DeleteAirConditioner(AirConditioner airConditioner)
        {
            _context = new();
            _context.AirConditioners.Remove(airConditioner);
            _context.SaveChanges();
        }

        public AirConditioner GetAirConditioner(int id)
        {
            _context = new();
            return _context.AirConditioners.FirstOrDefault(a => a.AirConditionerId == id);
        }

        public void CreateAirConditioner(AirConditioner airConditioner)
        {
            _context = new();
            _context.AirConditioners.Add(airConditioner);
            _context.SaveChanges();
        }

        public void UpdateAirConditioner(AirConditioner airConditioner)
        {
            _context = new();
            _context.AirConditioners.Update(airConditioner);
            _context.SaveChanges();
        }
    }
}
