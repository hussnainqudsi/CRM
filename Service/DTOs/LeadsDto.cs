using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static Common.Enums.Enums;

namespace Service.DTOs
{
    public class LeadsDto:CommonDto
    {
        public int LeadId { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string WhatsApp { get; set; }
        public Source SourceId { get; set; }
        public int SocietyId { get; set; }
        public Status StatusId { get; set; }
        public DateTime FollowUpDate { get; set; }
        public string Descrip { get; set; }
        public List<Description> description { get; set; }
        public Society societies { get; set; }
    }
}
