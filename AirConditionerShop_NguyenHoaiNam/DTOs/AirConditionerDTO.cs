using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop_NguyenHoaiNam.DTOs
{
    public class AirConditionerDTO
    {
        public int AirConditionerId { get; set; }

        public string AirConditionerName { get; set; } = null!;

        public string? Warranty { get; set; }

        public string? SoundPressureLevel { get; set; }

        public string? FeatureFunction { get; set; }

        public int? Quantity { get; set; }

        public double? DollarPrice { get; set; }

        public string SupplierId { get; set; } = null!;

        public string SupplierName { get; set; } = null!;
    }
}
