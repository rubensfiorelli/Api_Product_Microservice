namespace ShopWhiskey.Core.ValueObject
{
    public sealed record DeliveryAddress
    {
        public DeliveryAddress(int number, string street, string city, string state)
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
        }

        public int Number { get; private init; }
        public string Street { get; private init; }
        public string City { get; private init; }
        public string State { get; private init; }
    }
}
