using System;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests.Complex
{
    public class comTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(300000000, 2)]
        [InlineData(-1, 2.2342)]
        [InlineData(3, 200000000)]
        [InlineData(3.4968, -2)]

        public void indices(float x, float y)
        {
            com c = new com(x, y);
            Assert.Equal(c.real, x);
            Assert.Equal(c.imaginary, y);
            Assert.Equal(c.ToArray()[0], c.real);
            Assert.Equal(c.ToArray()[1], c.imaginary);
        }
        [Fact]
        public void construct()
        {
            com defaultConstructed = new com();
            Assert.Equal(0, defaultConstructed.real);
            Assert.Equal(0, defaultConstructed.imaginary);

            com specifiedComponents = new com(1, 2);
            Assert.Equal(1, specifiedComponents.real);
            Assert.Equal(2, specifiedComponents.imaginary);

            com fromArray = new com(new float[] { 1, 2 });
            Assert.Equal(1, fromArray.real);
            Assert.Equal(2, fromArray.imaginary);

            com fromcom = new com(specifiedComponents);
            Assert.Equal(1, fromcom.real);
            Assert.Equal(2, fromcom.imaginary);

            dcom source = new dcom(8, 5);
            com fromDcom = new com(source);
            Assert.Equal(8, fromDcom.real);
            Assert.Equal(5, fromDcom.imaginary);
        }

    }
}
