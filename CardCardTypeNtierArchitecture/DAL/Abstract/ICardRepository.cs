using CardCardTypeNtierArchitecture.Constants;
using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.DAL.Abstract
{
    public interface ICardRepository
    {
        public void Add(Card card);
        public void Delete(Guid id);
        public List<Card> Get();
        public void Update( Guid id, Card card);
        
    }
}
