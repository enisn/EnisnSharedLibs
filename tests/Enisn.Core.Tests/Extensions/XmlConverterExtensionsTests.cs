using Enisn.Core.Extensions;
using Moq;
using System;
using Xunit;

namespace Enisn.Core.Tests.Extensions
{
    public class XmlConverterExtensionsTests : IDisposable
    {
        private MockRepository mockRepository;



        public XmlConverterExtensionsTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private XmlConverterExtensions CreateXmlConverterExtensions()
        {
            return new XmlConverterExtensions();
        }

        [Fact]
        public void ToXml_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateXmlConverterExtensions();
            T value = TODO;
            bool ignoreExceptions = TODO;

            // Act
            var result = unitUnderTest.ToXml(
                value,
                ignoreExceptions);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void FromXml_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateXmlConverterExtensions();
            string xml = TODO;
            bool ignoreExceptions = TODO;

            // Act
            var result = unitUnderTest.FromXml(
                xml,
                ignoreExceptions);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void FromXml_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateXmlConverterExtensions();
            string xml = TODO;
            Type type = TODO;
            bool ignoreExceptions = TODO;

            // Act
            var result = unitUnderTest.FromXml(
                xml,
                type,
                ignoreExceptions);

            // Assert
            Assert.True(false);
        }
    }
}
