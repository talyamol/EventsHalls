﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Models
{
    public class EventsPostModel
    {
        
        public int HallId { get; set; }
        public string? Name { get; set; }
        public int CountInvited { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartHour { get; set; }
        public int MinAge { get; set; }
        public List<Invited> Inviteds { get; set; }
        public List<Halls> Halls { get; set; }

    }
}
