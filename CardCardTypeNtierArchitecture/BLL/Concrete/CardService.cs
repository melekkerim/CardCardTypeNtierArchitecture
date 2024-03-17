using AutoMapper;
using CardCardTypeNtierArchitecture.BLL.Abstract;
using CardCardTypeNtierArchitecture.DAL.Abstract;
using CardCardTypeNtierArchitecture.DTOs.CardDtos;
using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.BLL.Concrete
{
    public class CardService : ICardService
    {
        private readonly IMapper _mapper;
        private readonly ICardRepository _cardRepository;
        public CardService(IMapper mapper, ICardRepository cardRepository)
        {
            _mapper = mapper;
            _cardRepository = cardRepository;
        }
       
        
        public void Add(CardToAddDto dto)
        {
            Card card = _mapper.Map<Card>(dto);
            card.İd = Guid.NewGuid();
            _cardRepository.Add(card);
           
        }


        public void Delete(Guid id)
        {
            _cardRepository.Delete(id);
        }

        public List<CardToListDto> Get()
        {
            List<Card> cards = _cardRepository.Get();
            List<CardToListDto> cardToListDtos = _mapper.Map<List<CardToListDto>>(cards);
            
            return cardToListDtos;
        }

        public void Update(Guid id, CardToUpdateDto dto)
        {
            Card card = _mapper.Map<Card>(dto);
            card.İd = Guid.NewGuid();
            _cardRepository.Update(id,card);
        }

       
    }
}
