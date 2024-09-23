using System;
using System.Collections.Generic;

namespace ShowroomApi.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ManufactureId { get; set; }

    public string Color { get; set; } = null!;

    public string Power { get; set; } = null!;

    public long Price { get; set; }

    public virtual Manufacturer Manufacture { get; set; } = null!;
}
