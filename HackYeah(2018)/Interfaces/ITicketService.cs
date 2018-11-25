using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Models;

namespace HackYeah_2018_.Interfaces
{
    public interface ITicketService
    {
        Ticket GetTickets();
        Ticket AddTicket(Ticket addTicket);
        Ticket GetTicketById(int id);
    }
}
