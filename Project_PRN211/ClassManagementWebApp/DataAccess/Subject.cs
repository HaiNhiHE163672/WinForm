using System;
using System.Collections.Generic;

namespace ClassManagementWebApp.DataAccess;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
