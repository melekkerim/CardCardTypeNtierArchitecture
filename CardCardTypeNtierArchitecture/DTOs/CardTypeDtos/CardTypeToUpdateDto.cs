using CardCardTypeNtierArchitecture.DTOs.CardDtos;
using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.DTOs.CardTypeDtos
{
    public class CardTypeToUpdateDto
    {
        public string Name { get; set; }
        public List<CardToUpdateDto> Cards { get; set; }
    }
}