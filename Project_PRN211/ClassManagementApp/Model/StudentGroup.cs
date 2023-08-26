using System;
using System.Collections.Generic;

namespace ClassManagementApp.Model;

public partial class StudentGroup
{
    public int StudentId { get; set; }

    public int GroupId { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
