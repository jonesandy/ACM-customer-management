using ACM.BusinessLayer;
using Xunit;

namespace ACM.Repositories.Tests
{
    public class CustomerRepositoryTests
    {
        [Fact]
        public void RetrieveValid()
        {
            var sut = new CustomerRepository();
            var expectedCustomer = new Customer()
            {
                CustomerId = 1,
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            var actual = sut.Retrieve(1);

            Assert.Equal(actual.EmailAddress, expectedCustomer.EmailAddress);
            Assert.Equal(actual.FirstName, expectedCustomer.FirstName);
            Assert.Equal(actual.LastName, expectedCustomer.LastName);
        }
    }
}
