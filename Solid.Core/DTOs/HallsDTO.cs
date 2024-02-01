using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class HallsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountParticipants { get; set; }// = 300;
        public string City { get; set; }
        public string Street { get; set; }
        public string HallPhone { get; set; }
    }
}
