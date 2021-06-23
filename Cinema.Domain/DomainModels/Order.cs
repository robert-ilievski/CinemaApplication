using Cinema.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public CinemaApplicationUser User { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
