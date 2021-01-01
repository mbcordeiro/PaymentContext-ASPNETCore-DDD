using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
            var subscription = new Subscription(null);
            var student = new Student("Name", "LastName", "12345678912", "email@email.com");
            student.AddSubscription(subscription);
        }
    }
}
