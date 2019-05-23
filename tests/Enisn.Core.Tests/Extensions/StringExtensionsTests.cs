using Enisn.Core.Extensions;
using Moq;
using System;
using Xunit;

namespace Enisn.Core.Tests.Extensions
{
    public class StringExtensionsTests : IDisposable
    {
        private MockRepository mockRepository;



        public StringExtensionsTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private StringExtensions CreateStringExtensions()
        {
            return new StringExtensions();
        }

        [Fact]
        public void ToBase64_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateStringExtensions();
            string value = TODO;

            // Act
            var result = unitUnderTest.ToBase64(
                value);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void FromBase64_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateStringExtensions();
            string value = TODO;

            // Act
            var result = unitUnderTest.FromBase64(
                value);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ToShorten_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateStringExtensions();
            string value = TODO;
            int length = TODO;

            // Act
            var result = unitUnderTest.ToShorten(
                value,
                length);

            // Assert
            Assert.True(false);
        }
    }
}
