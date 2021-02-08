using Xunit;

namespace ACM.BusinessLayer.Tests
{
    public class CustomerTests
    {
        [Trait("Name", "Modify")]
        [Fact]
        public void Should_Set_FullName_Correctly()
        {
            var sut = new Customer()
            {
                FirstName = "John",
                LastName = "Doe"
            };
            var expectedName = "Doe, John";

            var result = sut.FullName;

            Assert.Equal(expectedName, result);
        }

        [Fact]
        public void Should_Not_Return_FullName_If_Only_FirstName_Set()
        {
            var sut = new Customer()
            {
                FirstName = "John"
            };
            var expectedName = "John";

            var result = sut.FullName;

            Assert.Equal(expectedName, result);
        }

        [Fact]
        public void Should_Not_Return_FullName_If_Only_LastName_Set()
        {
            var sut = new Customer()
            {
                LastName = "Doe"
            };
            var expectedName = "Doe";

            var result = sut.FullName;

            Assert.Equal(expectedName, result);
        }

        [Fact]
        public void Should_Validate_Correct_Customer_Data()
        {
            var sut = new Customer()
            {
                LastName = "Doe",
                EmailAddress = "none@none.none"
            };

            var result = sut.ValidCustomerData();

            Assert.True(result);
        }

        [Theory]
        [InlineData("", "none@none.none")]
        [InlineData("Doe", "")]
        public void Should_Validate_Correctly_With_Missing_Customer_Data(string lastName, string email)
        {
            var sut = new Customer()
            {
                LastName = lastName,
                EmailAddress = email
            };

            var result = sut.ValidCustomerData();

            Assert.False(result);
        }
    }
}
