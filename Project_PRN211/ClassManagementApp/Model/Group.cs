using System;
using System.Collections.Generic;

namespace ClassManagementApp.Model;

public partial class Group
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public int SubjectId { get; set; }

    public int LecturerId { get; set; }

    public string Status { get; set; } = null!;

    public virtual Lecturer Lecturer { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
