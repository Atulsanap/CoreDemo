using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Pickup { get; set; }
        public string Destination { get; set; }

        public DateTime IssueDate { get; set; }

        public string Classes { get; set; }
    }
}
