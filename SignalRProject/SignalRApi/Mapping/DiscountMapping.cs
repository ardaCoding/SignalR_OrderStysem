using AutoMapper;
using SignalR.Dto.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount,CreateDiscountDto>().ReverseMap();

            CreateMap<Discount, GetDiscountDto>().ReverseMap();

            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();

            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        }
    }
    }
    
    

