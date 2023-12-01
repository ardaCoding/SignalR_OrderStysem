using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinnesLayer.Abstract;
using SignalR.Dto.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategorList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult  CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.Tadd(new Category()
                {
                Name = createCategoryDto.Name,
                    Status=true

            });

            return Ok("kategori eklendi");

        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value= _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("kategori silindi");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
           
            return Ok(value);
        }


        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                Name= updateCategoryDto.Name,
                CategoryID= updateCategoryDto.CategoryID,
              Status=updateCategoryDto.Status

            });
            return Ok("kategori eklendi");
        }
    }
}
