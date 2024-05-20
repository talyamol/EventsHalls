using AutoMapper;
using Solid.Core.Entities;
using Solid.Core.Models;

namespace HallsEvents.Mapping
{
    public class PostModelMapping : Profile
    {
        public PostModelMapping()
        {
            CreateMap<EventsPostModel, Event>().ReverseMap();
            CreateMap<HallsPostModel, Halls>().ReverseMap();
            CreateMap<InvitedPostMosel, Invited>().ReverseMap();
        }

    }
}
