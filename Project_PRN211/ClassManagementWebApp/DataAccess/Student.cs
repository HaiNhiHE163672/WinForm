using System;
using System.Collections.Generic;

namespace ClassManagementWebApp.DataAccess;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
