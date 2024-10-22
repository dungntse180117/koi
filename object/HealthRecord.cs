using System;
using System.Collections.Generic;

namespace Bussinessobject;

public partial class HealthRecord
{
    public int RecordId { get; set; }

    public int? FishId { get; set; }

    public DateOnly? CheckupDate { get; set; }

    public string? HealthStatus { get; set; }

    public string? Treatment { get; set; }

    public string? Notes { get; set; }

 
}
