﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool SubscribeToNewsletter { get; set; }
    }
}
