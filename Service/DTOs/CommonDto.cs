using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTOs
{
    public class CommonDto
    {
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedById { get; set; }
        public int? ModifiedDate { get; set; }
    }
}
