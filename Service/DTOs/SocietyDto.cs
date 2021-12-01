using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static Common.Enums.Enums;

namespace Service.DTOs
{
    public class SocietyDto:CommonDto
    {
        public int SocietyId { get; set; }
        public int LeadId { get; set; }
        public string SocietyName { get; set; }
        public int Size { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Leads Leads { get; set; }
        public Category Category { get; set; }
    }
}
