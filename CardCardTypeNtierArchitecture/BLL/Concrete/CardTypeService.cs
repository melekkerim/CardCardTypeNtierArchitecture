using AutoMapper;
using CardCardTypeNtierArchitecture.BLL.Abstract;
using CardCardTypeNtierArchitecture.DAL.Abstract;
using CardCardTypeNtierArchitecture.DTOs.CardTypeDtos;
using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.BLL.Concrete
{
    public class CardTypeService : ICardTypeService
    {
        private readonly ICardTypeRepository _cardTypeRepository;
        private readonly IMapper _mapper;
        public CardTypeService(ICardTypeRepository cardTypeRepository, IMapper mapper)
        {
            _cardTypeRepository = cardTypeRepository;
            _mapper = mapper;
        }
        public void Add(CardTypeToAddDto dto)
        {
            CardType cardType = _mapper.Map<CardType>(dto);
            cardType.Id= Guid.NewGuid();
            _cardTypeRepository.Add(cardType);
        }

        public void Delete(Guid id)
        {
            _cardTypeRepository.Delete(id);
        }

        public List<CardTypeToListDto> Get()
        {
            var cardTypes = _cardTypeRepository.Get();

            List<CardTypeToListDto> cardTypeToListDtos = _mapper.Map<List<CardTypeToListDto>>(cardTypes);

            return cardTypeToListDtos;
        }

        public void Update(Guid id, CardTypeToUpdateDto dto)
        {
            CardType cardType = _mapper.Map<CardType>(dto);
            cardType.Name = dto.Name;
            cardType.Id = Guid.NewGuid();
            _cardTypeRepository.Update(id, cardType);
        }
    }
}
