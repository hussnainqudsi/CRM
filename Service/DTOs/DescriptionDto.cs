using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTOs
{
    public class DescriptionDto:CommonDto
    {
        public int DescriptionId { get; set; }
        public int LeadId { get; set; }
        public string Descriptions { get; set; }
        public DateTime? NextFollowUp { get; set; }
        public Leads Leads { get; set; }
    }
}
