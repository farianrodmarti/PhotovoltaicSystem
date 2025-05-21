using PhotovoltaicSystem.Domain.Common;

namespace PhotovoltaicSystem.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        
        #region Properties 
        public string Street { get; init; }
        public string City { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }

        #endregion
        public Address(string street, string city, string postalCode, string country)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new[] { Street, City, PostalCode, Country };
        }
    }
}
