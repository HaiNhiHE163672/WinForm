using System;
using System.Collections.Generic;

namespace ClassManagementApp.Model;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();

    public override string ToString()
    {
        return SubjectName;
    }
}
