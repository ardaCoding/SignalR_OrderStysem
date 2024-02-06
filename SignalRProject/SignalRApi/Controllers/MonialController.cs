using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinnesLayer.Abstract;
using SignalR.Dto.MonialDto;
using SignalR.Dto.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonialController : ControllerBase
    {
        private readonly IMonialService _monialService;
        private readonly IMapper _mapper;
        public MonialController(IMonialService monialService, IMapper mapper)
        {
            _monialService = monialService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult MonialList()
        {
            var value = _mapper.Map<List<ResultMonialDto>>(_monialService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateMonial(CreateMonialDto createMonialDto)
        {
            _monialService.Tadd(new Monial()
            {
                Name = createMonialDto.Name,
                Status = createMonialDto.Status,
                Title = createMonialDto.Title,
                ImageUrl = createMonialDto.ImageUrl,
                Comment = createMonialDto.Comment



            });

            return Ok(" yorum yapıldı");
        }

        [HttpDelete]
        public IActionResult DeleteMonial(int id)
        {
            var value = _monialService.TGetByID(id);
            _monialService.TDelete(value);
            return Ok(" yorum  silindi");
        }
        [HttpGet("GetComment")]
        public IActionResult GetMonial(int id)
        {
            var value = _monialService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateMonial(UpdateMonialDto updateMonialDto)
        {
            _monialService.TUpdate(new Monial()
            {
                Name = updateMonialDto.Name,
                Status = updateMonialDto.Status,
                Title = updateMonialDto.Title,
                ImageUrl = updateMonialDto.ImageUrl,
                Comment = updateMonialDto.Comment,
                monialID = updateMonialDto.monialID


            });
            return Ok(" yorumlar güncellendi");













        }
    }
}
