using System;
using System.Collections.Generic;

namespace ZH2_M9PVND.Models;

public partial class Rating
{
    public int RatingId { get; set; }

    public string Ratingvalue { get; set; } = null!;

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();
}
