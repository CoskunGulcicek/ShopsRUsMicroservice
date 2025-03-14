﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.IdentityServer.Dtos
{
    public class AppUserAddDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsMember { get; set; }
        public DateTime MemberRegistrationTime = DateTime.Now;
    }
}
