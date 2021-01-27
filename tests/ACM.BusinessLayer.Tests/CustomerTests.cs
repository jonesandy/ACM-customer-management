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
    }
}
