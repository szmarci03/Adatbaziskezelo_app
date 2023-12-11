using System;
using System.Collections.Generic;

namespace ZH2_M9PVND.Models;

public partial class Type
{
    public int TypeId { get; set; }

    public string Typename { get; set; } = null!;

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();
}
