using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntitiyLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
            
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About
            {
                ImageURL = createAboutDto.ImageURL,
                Title = createAboutDto.Title,
                Description = createAboutDto.Description
            };
            _aboutService.TAdd(about);
            return Ok("Hakkinda kismi eklendi!");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Hakkinda kismi silindi!");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About
            {
                AboutID = updateAboutDto.AboutID,
                ImageURL = updateAboutDto.ImageURL,
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkinda kismi guncellendi!");
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
           var value =_aboutService.TGetByID(id);
            return Ok(value);
        }
    }
}
