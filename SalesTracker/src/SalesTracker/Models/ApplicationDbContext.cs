﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}
