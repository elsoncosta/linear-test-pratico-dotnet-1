﻿

using Microsoft.AspNet.Identity.EntityFramework;

namespace LinearTestPratico.Infra.CrossCutting.Identity.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }
    }
}
