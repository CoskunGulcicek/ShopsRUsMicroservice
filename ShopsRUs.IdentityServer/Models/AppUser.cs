﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.IdentityServer.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsMember { get; set; }
        public DateTime MemberRegistrationTime { get; set; }
    }
}
