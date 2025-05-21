using PhotovoltaicSystem.Domain.Common;
using PhotovoltaicSystem.Domain.ValueObjects;

namespace PhotovoltaicSystem.Domain.Entities.Abstract
{
    public abstract class Housing : Entity
    {
        #region Properties
        public int HouseNumber { get; init; }
        public Address Address { get; init; }
        public PhotovoltaicSystemInstall PhotovoltaicSystem { get; init; }
        #endregion

        protected Housing() { }

        protected Housing(int houseNumber, Address address) : base(new Guid())
        {
            HouseNumber = houseNumber;
            Address = address;
        }
    }
}
