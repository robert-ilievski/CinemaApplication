using Cinema.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Identity
{
    public class CinemaApplicationUser : IdentityUser
    {
        public string Role { get; set; } = "ROLE_USER";
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
