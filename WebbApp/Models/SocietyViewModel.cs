using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbApp.Models
{
    public class SocietyViewModel
    {
        public List<SocietyDto> ListSociety { get; set; }
        public SocietyDto Society { get; set; }
    }
}
