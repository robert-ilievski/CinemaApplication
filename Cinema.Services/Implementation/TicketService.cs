using Cinema.Domain.DomainModels;
using Cinema.Repository.Interface;
using Cinema.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Services.Implementation
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> _TicketRepository;
        public TicketService(IRepository<Ticket> TicketRepository)
        {
            _TicketRepository = TicketRepository;
        }

        public void CreateNewTicket(Ticket t)
        {
            this._TicketRepository.Insert(t);
        }

        public void DeleteTicket(Guid id)
        {
            var Ticket = this.GetDetailsForTicket(id);
            this._TicketRepository.Delete(Ticket);
        }

        public List<Ticket> GetAllTickets()
        {
            return this._TicketRepository.GetAll().ToList();
        }

        public Ticket GetDetailsForTicket(Guid? id)
        {
            return this._TicketRepository.Get(id);
        }

        public void UpdateExistingTicket(Ticket t)
        {
            this._TicketRepository.Update(t);
        }
    }
}
