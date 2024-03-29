﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinnesLayer.Abstract;
using SignalR.Dto.CategoryDto;
using SignalR.Dto.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.Tadd(new Contact()
            {
                FooterDescr = createContactDto.FooterDescr,
                Location = createContactDto.Location,
                Mail = createContactDto.Mail,
                Phone = createContactDto.Phone


            });

            return Ok(" bilgiler eklendi");

        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("iletisim bilgisi silindi");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);

            return Ok(value);
        }


        [HttpPut]
        public IActionResult UpdateCategory(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {

                ContactID = updateContactDto.ContactID,
                FooterDescr = updateContactDto.FooterDescr,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,
                Phone = updateContactDto.Phone


            });
            return Ok("bilgiler güncellendi");

        }
    }
}
