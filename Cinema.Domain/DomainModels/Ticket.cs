using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Domain.DomainModels
{
    public class Ticket : BaseEntity
    {
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string MovieGenre { get; set; }
        [Required]
        public string MovieYear { get; set; }
        [Required]
        public string MovieDescription { get; set; }
        [Required]
        public string MovieImage { get; set; }
        [Required]
        public int TicketPrice { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketsInShoppingCart { get; set; }
        public IEnumerable<TicketInOrder> TicketsInOrder { get; set; }
    }
}
