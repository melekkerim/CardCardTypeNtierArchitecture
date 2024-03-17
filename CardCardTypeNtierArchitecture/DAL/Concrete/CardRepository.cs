using CardCardTypeNtierArchitecture.Constants;
using CardCardTypeNtierArchitecture.DAL.Abstract;
using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.DAL.Concrete
{
    public class CardRepository : ICardRepository
    {
        public void Add(Card card)
        {
            card.İd = Guid.NewGuid();
            Datas.Cards.Add(card);
           
        }

        public void Delete(Guid id)
        {
            var data = Datas.Cards.Single(m=>m.İd== id);
            Datas.Cards.Remove(data);
        }

        public List<Card> Get()
        {
            return Datas.Cards;
            
        }


        public void Update(Guid id, Card card)
        {
            Card entity = Datas.Cards.Single(m => m.İd == id);
            entity.Number = card.Number;
            entity.CVV = card.CVV;
        }
    }
}
