using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserManagementSystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }
    public byte[]? Picture { get; set; }

    public DateTime DOB { get; set; }

    public string MaritalStatus { get; set; }
    public string? Gender { get; set; }
}

