using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Enums
{
    public class Enums
    {
        public enum Category
        {
            Apartment = 1,
            Commercial =2,
            Residential=3,
            Villas=4  
        }
        public enum Source
        {
            facebook=1,
            Instagram=2,
            Website=3
        }
        public enum Status
        {
            Pending=1,
            Completed=2,
            Canceled=3,
            In_Progress = 4
        }
    }
}
