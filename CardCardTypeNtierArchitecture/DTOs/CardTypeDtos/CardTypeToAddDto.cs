using CardCardTypeNtierArchitecture.DTOs.CardDtos;

namespace CardCardTypeNtierArchitecture.DTOs.CardTypeDtos
{
    public class CardTypeToAddDto
    {
        public string Name { get; set; }
        public List<CardToAddDto> Cards { get; set; }
    }
}
