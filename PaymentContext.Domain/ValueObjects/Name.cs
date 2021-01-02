using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lasttName)
        {
            FirstName = firstName;
            LasttName = lasttName;

            if (string.IsNullOrEmpty(FirstName))
                AddNotification("Name.FirtName", "Nome inválido1");
        }

        public string FirstName { get; private set; }
        public string LasttName { get; private set; }
    }
}
