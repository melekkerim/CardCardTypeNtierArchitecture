using CardCardTypeNtierArchitecture.DTOs.CardDtos;

namespace CardCardTypeNtierArchitecture.BLL.Abstract
{
    public interface ICardService
    {
        public void Add(CardToAddDto dto);
        public void Delete(Guid id);
        public List<CardToListDto> Get();
        public void Update( Guid id, CardToUpdateDto dto);
    }


}
