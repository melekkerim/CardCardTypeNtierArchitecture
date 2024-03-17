using AutoMapper;
using CardCardTypeNtierArchitecture.BLL.Abstract;
using CardCardTypeNtierArchitecture.DTOs.CardTypeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardCardTypeNtierArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardTypeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICardTypeService _cardTypeService;

        public CardTypeController(IMapper mapper, ICardTypeService cardTypeService)
        {
            _mapper = mapper;
            _cardTypeService = cardTypeService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var responce = _cardTypeService.Get();
            return Ok(responce);
        }

        [HttpPost]
        public IActionResult Add(CardTypeToAddDto dto)
        {
            _cardTypeService.Add(dto);
            return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult Update( Guid id, CardTypeToUpdateDto dto)
        {
            _cardTypeService.Update(id, dto);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _cardTypeService.Delete(id);
            return Ok();
        }
    }
}
