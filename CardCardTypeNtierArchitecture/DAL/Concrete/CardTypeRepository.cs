using CardCardTypeNtierArchitecture.Constants;
using CardCardTypeNtierArchitecture.DAL.Abstract;
using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.DAL.Concrete
{
    public class CardTypeRepository : ICardTypeRepository
    {
        public void Add(CardType cardType)
        {
            cardType.Id = Guid.NewGuid();
            Datas.CardTypes.Add(cardType);
           
        }

        public void Delete(Guid id)
        {
           var entity = Datas.CardTypes.Single(m=>m.Id == id);
            Datas.CardTypes.Remove(entity);
        }

        public List<CardType> Get()
        {
            List<CardType> entities = Datas.CardTypes;
            return entities;
        }

        public void Update(Guid id, CardType cardType)
        {
            var entity = Datas.CardTypes.Single(m=>m.Id == id);
            entity.Name = cardType.Name;
            List<Card> cards = entity.Cards;
            List<Card> cards1= new List<Card>();
            foreach (var card in cards)
            {
                Card card1 = new Card()
                {
                    Number = card.Number,
                    CVV = card.CVV,
                    İd = Guid.NewGuid(),
                };
                cards1.Add(card1);
                entity.Cards=cards1;
            }
        }
    }
}
