using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbApp.Models
{
    public class LeadsViewModel
    {
        public List<LeadsDto> ListLeads { get; set; }
        public LeadsDto Leads { get; set; }
        public List<SocietyDto> ListSociety { get; set; }
        public DescriptionDto Description { get; set; }
        public List<DescriptionDto> ListDescription { get; set; }
    }
}
