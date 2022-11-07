﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RamosGuillenTrujilloProyectoPorgreso1.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser5 class
public class ApplicationUser5 : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

public class ApplicationRole : IdentityRole
{

}

