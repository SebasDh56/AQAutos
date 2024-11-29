using System;
using System.Collections.Generic;

namespace AQAPIAuto.Data.Models;

public partial class Aqauto
{
    public int AqautoId { get; set; }

    public string Aqmarca { get; set; } = null!;

    public int Aqanio { get; set; }

    public string? Aqcombustible { get; set; }

    public bool Aqusado { get; set; }

    public decimal Aqprecio { get; set; }

    public string? AqEmaildistribuidor { get; set; }

    public DateTime AqfechaIngreso { get; set; }
}
