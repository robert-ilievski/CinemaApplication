﻿using Cinema.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Interface
{
    public interface ITicketService
    {
        List<Ticket> GetAllTickets();
        Ticket GetDetailsForTicket(Guid? id);
        void CreateNewTicket(Ticket t);
        void UpdateExistingTicket(Ticket t);
        void DeleteTicket(Guid id);
    }
}
