using System;
using System.Collections.Generic;

namespace ZH2_M9PVND.Models;

public partial class Actor
{
    public int ActorId { get; set; }

    public string ActorName { get; set; } = null!;

    public virtual ICollection<ShowActor> ShowActors { get; set; } = new List<ShowActor>();
}
