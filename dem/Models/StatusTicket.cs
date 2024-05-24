using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dem.Models
{
    public class StatusTicket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
