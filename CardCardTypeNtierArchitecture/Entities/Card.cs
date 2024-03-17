namespace CardCardTypeNtierArchitecture.Entities
{
    public class Card
    {
        public Guid İd = Guid.NewGuid();
        public string Number { get; set; }
        public string CVV { get; set; }

    }
}
