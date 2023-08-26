using System;
using System.Collections.Generic;

namespace ClassManagementWebApp.DataAccess;

public partial class Lecturer
{
    public int LecturerId { get; set; }

    public string LecturerName { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public DateTime? Dob { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
