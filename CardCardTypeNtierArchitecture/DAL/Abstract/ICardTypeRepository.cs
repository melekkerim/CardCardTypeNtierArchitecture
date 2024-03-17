using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.DAL.Abstract
{
    public interface ICardTypeRepository
    {
        public void Add(CardType cardType);
        public void Delete(Guid id);
        public List<CardType> Get();
        public void Update( Guid id, CardType cardType);
    }
}
