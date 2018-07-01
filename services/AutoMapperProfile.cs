using AutoMapper;
using Models.Ad.Entities;
using Models.Ad.Models;

namespace Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Ad, AdModel>().ReverseMap();
        }
    }
}
