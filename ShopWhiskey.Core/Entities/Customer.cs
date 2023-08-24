using ShopWhiskey.Core.Prime;
using ShopWhiskey.Core.ValueObject;

namespace ShopWhiskey.Core.Entities
{
    public sealed class Customer : BaseEntity
    {
        public Customer(string firstName, string lastName, string email, string whatsApp) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            WhatsApp = whatsApp;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string WhatsApp { get; private set; }
        public DeliveryAddress? Address { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void SetCustomer(string newFirstname, string newLastName, string newEmail, string newWhatsApp)
        {

            FirstName = newFirstname;
            LastName = newLastName;
            Email = newEmail;
            WhatsApp = newWhatsApp;

        }

    }



}
