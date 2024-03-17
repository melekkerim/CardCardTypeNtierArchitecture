namespace CardCardTypeNtierArchitecture.Entities
{
    public class CardType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
