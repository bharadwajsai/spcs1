using AutoMapper;
using models.ad.entities;
using models.ad.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;

namespace services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Ad, Advm>().ReverseMap();
        }
    }
}
