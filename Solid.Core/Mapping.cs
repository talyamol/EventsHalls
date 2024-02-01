using Solid.Core.DTOs;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class Mapping
    {
        public EventDTO mapToEventDTO(Event e)
        {
            EventDTO mapDTO = new EventDTO() { CountInvited = e.CountInvited, Date = e.Date, HallId = e.HallId, Id = e.Id, MinAge = e.MinAge, Name = e.Name, StartHour = e.StartHour };
            return mapDTO;
        }

        public HallsDTO mapToHallDTO(Halls hall)
        {
            HallsDTO mapDTO = new HallsDTO() { Name = hall.Name, Id = hall.Id, City = hall.City, CountParticipants = hall.CountParticipants, HallPhone = hall.HallPhone, Street = hall.Street };
            return mapDTO;
        }

        public InvitedDTO mapToInvitedDTO(Invited invited)
        {
            InvitedDTO invitedDTO = new InvitedDTO()
            { Name = invited.Name, Id = invited.Id, Age = invited.Age, Email = invited.Email, IdEvent = invited.IdEvent };
       return invitedDTO;
        }
    }
}
