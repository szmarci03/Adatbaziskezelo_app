using System;
using System.Collections.Generic;

namespace ZH2_M9PVND.Models;

public partial class ShowActor
{
    public int ShowActorId { get; set; }

    public int ShowId { get; set; }

    public int ActorId { get; set; }

    public virtual Actor Actor { get; set; } = null!;

    public virtual Show Show { get; set; } = null!;
}
