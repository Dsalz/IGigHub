using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IGigHub.Controllers.Api;
using AutoMapper;
using IGigHub.Dtos;
using IGigHub.Models;

namespace IGigHub.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<Gig, GigDto>();
            CreateMap<Notification, NotificationDto>();
        }
    }
}