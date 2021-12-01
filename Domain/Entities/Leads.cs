using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Leads
    {
        [Key]
        public int LeadId { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string WhatsApp { get; set; }
        public int SourceId { get; set; }
        public int StatusId { get; set; }
        public int SocietyId { get; set; }
        public DateTime FollowUpDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedById { get; set; }
        public int? ModifiedDate { get; set; }
        public List<Description> description { get; set; }
        public Society societies { get; set; }
    }
}
