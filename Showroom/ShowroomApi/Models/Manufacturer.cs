using System;
using System.Collections.Generic;

namespace ShowroomApi.Models;

public partial class Manufacturer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
