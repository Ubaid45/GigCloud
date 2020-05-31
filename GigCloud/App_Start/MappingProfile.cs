using AutoMapper;
using GigCloud.Core.Dtos;
using GigCloud.Core.Models;

namespace GigCloud
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<Gig, GigDto>();
            CreateMap<Notification, NotificationDto>();

            // Dto to Domain
            /* CreateMap<CustomerDto, Customer>()
                 .ForMember(c => c.Id, opt => opt.Ignore());

             CreateMap<MovieDto, Movie>()
                 .ForMember(c => c.Id, opt => opt.Ignore());*/

        }
    }

}