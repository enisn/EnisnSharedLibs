using Enisn.Core.Helpers;
using Moq;
using System;
using Xunit;

namespace Enisn.Core.Tests.Helpers
{
    public class RandomFactoryTests : IDisposable
    {
        private MockRepository mockRepository;



        public RandomFactoryTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private RandomFactory CreateFactory()
        {
            return new RandomFactory();
        }

        [Fact]
        public void GetString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateFactory();
            int length = TODO;

            // Act
            var result = unitUnderTest.GetString(
                length);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetInt32_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateFactory();
            int max = TODO;
            int min = TODO;

            // Act
            var result = unitUnderTest.GetInt32(
                max,
                min);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetEmail_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateFactory();

            // Act
            var result = unitUnderTest.GetEmail();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetChar_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateFactory();

            // Act
            var result = unitUnderTest.GetChar();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetEnum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateFactory();

            // Act
            var result = unitUnderTest.GetEnum();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetBool_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateFactory();
            int successRate = TODO;

            // Act
            var result = unitUnderTest.GetBool(
                successRate);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetDateTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateFactory();

            // Act
            var result = unitUnderTest.GetDateTime();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetImageUrl_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateFactory();

            // Act
            var result = unitUnderTest.GetImageUrl();

            // Assert
            Assert.True(false);
        }
    }
}
