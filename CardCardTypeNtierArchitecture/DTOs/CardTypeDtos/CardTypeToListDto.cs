using CardCardTypeNtierArchitecture.DTOs.CardDtos;
using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.DTOs.CardTypeDtos
{
    public class CardTypeToListDto
    {
        public Guid Id {get; set; }
        public string Name { get; set; }
        public List<CardToListDto> Cards { get; set; }
    }
}
