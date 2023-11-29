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
    public class comDerivationTests // Adapted from vec2DerivationTests
    {
        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        [InlineData(new object[] { 3, 4 })]
        [InlineData(new object[] { 15.23f, 20.99999999999f })]
        [InlineData(new object[] { 2, -5 })]

        public void arbitraryNormalisation(float re, float im)
        {
            com original = new com(re, im);
            com normalised = original.normalised;
            com reconstructed = normalised * original.norm;

            Assert.Equal(original.norm, original.Norm);
            Assert.Equal(original.argument, original.Argument);

            Assert.True(Math.Abs(reconstructed.real - original.real) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(reconstructed.imaginary - original.imaginary) < scalar.floatComparisonTolerance);

            com working = new com(re, im);
            float norm = working.norm;
            working.normalise();
            Assert.True(Math.Abs(working.norm - 1) < scalar.floatComparisonTolerance);
            working *= norm;
            Assert.True(Math.Abs(working.norm - norm) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(re - working.real) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(im - working.imaginary) < scalar.floatComparisonTolerance);
        }
    }
}
