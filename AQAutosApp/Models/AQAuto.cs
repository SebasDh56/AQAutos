using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQAutosApp.Models
{
    public class AQAuto
    {
        public int aqautoId { get; set; }
        public string aqmarca { get; set; }
        public int aqanio { get; set; }
        public string aqcombustible { get; set; }
        public bool aqusado { get; set; }
        public decimal aqprecio { get; set; }
        public string aqEmaildistribuidor { get; set; }
        public DateTime aqfechaIngreso { get; set; }
    }
}
