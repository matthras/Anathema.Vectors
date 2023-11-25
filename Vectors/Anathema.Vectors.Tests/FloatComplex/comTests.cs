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

        [Fact]
        public void equality()
        {
            float a = 1.0f;
            float b = a / 3.0f;
            float c = b * 3.0f;
            float d = 0.999999999999f;

            com x = new com(a, c);
            com y = new com(c, a);
            com z = new com(d, d);
            com w = new com(1.1f, a);
            com nullvec = null;

            Assert.True(x.Equals(y));
            Assert.False(x.Equals(nullvec));
            Assert.False(x.Equals("String"));
            Assert.True(nullvec == null);
            Assert.True(null == nullvec);
            Assert.False(nullvec == x);
            Assert.False(x == nullvec);
            Assert.False(nullvec != null);
            Assert.False(null != nullvec);
            Assert.True(nullvec != x);
            Assert.True(x != nullvec);

            Assert.False(x == null);
            Assert.False(null == x);
            Assert.True(x != null);
            Assert.True(null != x);

            Assert.True(x == y);
            Assert.True(y == z);
            Assert.True(z == x);
            Assert.False(w == x);
            Assert.False(w == y);
            Assert.False(w == z);
            Assert.True(w == w);

            Assert.False(x != y);
            Assert.False(y != z);
            Assert.False(z != x);

            Assert.True(w != x);
            Assert.True(w != y);
            Assert.True(w != z);
            Assert.False(w != w);
        }

    }
}
