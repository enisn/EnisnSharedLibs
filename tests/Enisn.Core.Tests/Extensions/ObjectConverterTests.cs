using Enisn.Core.Extensions;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Enisn.Core.Tests.Extensions
{
    public class ObjectConverterTests : IDisposable
    {
        private MockRepository mockRepository;



        public ObjectConverterTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private ObjectConverter CreateObjectConverter()
        {
            return new ObjectConverter();
        }

        [Fact]
        public void CopyPropertiesFrom_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateObjectConverter();
            T to = TODO;
            object from = TODO;

            // Act
            var result = unitUnderTest.CopyPropertiesFrom(
                to,
                from);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void CopyPropertiesFrom_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateObjectConverter();
            T to = TODO;
            object from = TODO;
            bool ignoreNulls = TODO;

            // Act
            var result = unitUnderTest.CopyPropertiesFrom(
                to,
                from,
                ignoreNulls);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ConvertTo_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateObjectConverter();
            object data = TODO;

            // Act
            var result = unitUnderTest.ConvertTo(
                data);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ConvertTo_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateObjectConverter();
            object data = TODO;
            Type type = TODO;

            // Act
            var result = unitUnderTest.ConvertTo(
                data,
                type);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetValueSafely_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateObjectConverter();
            Dictionary<TKey, TValue> dict = TODO;
            TKey key = TODO;

            // Act
            var result = unitUnderTest.GetValueSafely(
                dict,
                key);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ToGeneric_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateObjectConverter();
            IEnumerable enumerable = TODO;

            // Act
            var result = unitUnderTest.ToGeneric(
                enumerable);

            // Assert
            Assert.True(false);
        }
    }
}
