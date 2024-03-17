using CardCardTypeNtierArchitecture.DTOs.CardTypeDtos;

namespace CardCardTypeNtierArchitecture.BLL.Abstract
{
    public interface ICardTypeService
    {
        public void Add(CardTypeToAddDto dto);
        public void Delete(Guid id);
        public void Update(Guid id, CardTypeToUpdateDto dto);
        public List<CardTypeToListDto> Get();
    }
}
