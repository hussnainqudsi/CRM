using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Description
    {
        [Key]
        public int DescriptionId { get; set; }
        [ForeignKey("LeadId")]
        public int LeadId { get; set; }
        public string Descriptions { get; set; }
        public Leads Leads { get; set; }
        public DateTime? NextFollowUp { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedById { get; set; }
        public int? ModifiedDate { get; set; }
    }
}
