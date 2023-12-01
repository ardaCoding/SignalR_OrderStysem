using AutoMapper;
using SignalR.Dto.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product, GetProductdto>().ReverseMap();
            CreateMap<Product, UpdateProductdto>().ReverseMap();
            CreateMap<Product, ResultProductdto>().ReverseMap();
        }
    }
}
