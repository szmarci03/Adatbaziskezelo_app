using System;
using System.Collections.Generic;

namespace ZH2_M9PVND.Models;

public partial class Show
{
    public int ShowId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime? DateAdded { get; set; }

    public int? ReleaseYear { get; set; }

    public int RatingId { get; set; }

    public int TypeId { get; set; }

    public virtual Rating Rating { get; set; } = null!;

    public virtual ICollection<ShowActor> ShowActors { get; set; } = new List<ShowActor>();

    public virtual Type Type { get; set; } = null!;
}
