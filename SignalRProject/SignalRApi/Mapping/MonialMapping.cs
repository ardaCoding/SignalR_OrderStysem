using AutoMapper;
using SignalR.Dto.MonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class MonialMapping:Profile
    {
        public MonialMapping()
        {
            CreateMap<Monial,GetMonialDto>().ReverseMap();
            CreateMap<Monial, UpdateMonialDto>().ReverseMap();
            CreateMap<Monial, CreateMonialDto>().ReverseMap();
            CreateMap<Monial, ResultMonialDto>().ReverseMap();
        }
    }
}
