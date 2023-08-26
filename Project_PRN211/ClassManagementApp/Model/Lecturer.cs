using System;
using System.Collections.Generic;

namespace ClassManagementApp.Model;

public partial class Lecturer
{
    public int LecturerId { get; set; }

    public string LecturerName { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();

    public override string ToString()
    {
        return LecturerName;
    }
}
