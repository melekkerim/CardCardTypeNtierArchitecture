using AutoMapper;
using CardCardTypeNtierArchitecture.BLL.Abstract;
using CardCardTypeNtierArchitecture.DTOs.CardDtos;
using Microsoft.AspNetCore.Mvc;

namespace CardCardTypeNtierArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
       private readonly ICardService _cardService;
        private readonly IMapper _mapper;
        public CardController(ICardService cardService, IMapper mapper)
        {
            _cardService = cardService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cardService.Get());
        }

        [HttpPost]
        public IActionResult Add([FromBody] CardToAddDto dto)
        {
            _cardService.Add(dto);
            
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] CardToUpdateDto dto)
        {
            _cardService.Update(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            _cardService.Delete(id);
            return Ok();
        }
    }
}
