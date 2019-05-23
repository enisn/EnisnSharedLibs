using Enisn.Core.Extensions;
using Moq;
using System;
using Xunit;

namespace Enisn.Core.Tests.Extensions
{
    public class UrlExtensionsTests : IDisposable
    {
        private MockRepository mockRepository;



        public UrlExtensionsTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private UrlExtensions CreateUrlExtensions()
        {
            return new UrlExtensions();
        }

        [Fact]
        public void ToQueryString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateUrlExtensions();
            object obj = TODO;
            string parent = TODO;
            bool ignoreNulls = TODO;

            // Act
            var result = unitUnderTest.ToQueryString(
                obj,
                parent,
                ignoreNulls);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ApplyParams_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateUrlExtensions();
            string url = TODO;
            object[] parameters = TODO;

            // Act
            var result = unitUnderTest.ApplyParams(
                url,
                parameters);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ApplyParams_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateUrlExtensions();
            string url = TODO;

            // Act
            var result = unitUnderTest.ApplyParams(
                url);

            // Assert
            Assert.True(false);
        }
    }
}
