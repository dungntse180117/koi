using System;
using System.Collections.Generic;

namespace Bussinessobject;

public partial class FishInformation
{
    public int FishId { get; set; }

    public string? Species { get; set; }

    public int? Age { get; set; }

    public double? SizeCm { get; set; }

    public DateOnly? DateAcquired { get; set; }

    public virtual ICollection<HealthRecord> HealthRecords { get; set; } = new List<HealthRecord>();
}
