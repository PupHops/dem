using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime? DateAdd { get; set; } 
        public string Device { get; set; } 
        public string FaultType { get; set; }
        public string ProblemDescription { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public int StatusTicketId { get; set; }

        public Employee Employee { get; set; }
        public Client Client { get; set; }

        public StatusTicket StatusTicket { get; set; }



    }
}
