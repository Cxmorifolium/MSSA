using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace carinventory.Model
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string? VehicleMake {  get; set; }
        public string? VehicleModel { get; set; }
        public int VehicleYear { get; set; }
        public float VehiclePrice { get; set; }

    }
}
