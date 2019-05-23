using Enisn.Core.Extensions;
using Moq;
using Newtonsoft.Json;
using System;
using Xunit;

namespace Enisn.Core.Tests.Extensions
{
    public class JsonConverterExtensionsTests : IDisposable
    {
        private MockRepository mockRepository;



        public JsonConverterExtensionsTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private JsonConverterExtensions CreateJsonConverterExtensions()
        {
            return new JsonConverterExtensions();
        }

        [Fact]
        public void ToJson_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateJsonConverterExtensions();
            object obj = TODO;
            bool ignoreNulls = TODO;

            // Act
            var result = unitUnderTest.ToJson(
                obj,
                ignoreNulls);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ToJson_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateJsonConverterExtensions();
            object obj = TODO;
            JsonSerializerSettings settings = TODO;

            // Act
            var result = unitUnderTest.ToJson(
                obj,
                settings);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void FromJson_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateJsonConverterExtensions();
            string json = TODO;
            bool ignoreExceptions = TODO;
            bool ignoreNulls = TODO;

            // Act
            var result = unitUnderTest.FromJson(
                json,
                ignoreExceptions,
                ignoreNulls);

            // Assert
            Assert.True(false);
        }
    }
}
