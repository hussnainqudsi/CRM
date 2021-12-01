using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Society
    {
        [Key]
        public int SocietyId { get; set; }
        [ForeignKey("LeadId")]
        public int LeadId { get; set; }
        public string SocietyName { get; set; }
        public int Size { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Category { get; set; }
        public Leads Leads { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedById { get; set; }
        public int? ModifiedDate { get; set; }
    }
}
