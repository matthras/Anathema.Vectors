#if DOUBLES_ENABLED
#if COMPLEX_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// Double precision doubleing point complex number
    /// </summary>
    public class dcom
    {
        public override bool Equals(object o)
        {
            if (o is dcom)
                return ((dcom)o) == this;
            else
                return false;
        }
        public double real { get; set; }
        public double imaginary { get; set; }
        public double norm => (double)Math.Sqrt((real * real) + (imaginary * imaginary));
        public double argument => (double)Math.Atan2(imaginary, real);

        public dcom()
        {

        }
        public dcom(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public dcom(double[] ri)
        {
            this.real = ri[0];
            this.imaginary = ri[1];
        }
        public static dcom Conj(dcom a)
        {
            return new dcom(a.real, a.imaginary * (-1));
        }

        public static dcom operator +(dcom a, dcom b)
        {
            return new dcom(a.real + b.real, a.imaginary + b.imaginary);
        }
        public static dcom operator -(dcom a, dcom b)
        {
            return new dcom(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static dcom operator *(dcom a, dcom b)
        {
            return new dcom((a.real * b.real) - (a.imaginary * b.imaginary),
                (a.real * b.imaginary) + (b.real * a.imaginary));
        }
        public static dcom operator /(dcom a, dcom b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator +(dcom a, double b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator -(dcom a, double b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator *(dcom a, double b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator /(dcom a, double b)
        {
            throw new NotImplementedException();
        }

        public static dcom operator +(double a, dcom b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator -(double a, dcom b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator *(double a, dcom b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator /(double a, dcom b)
        {
            throw new NotImplementedException();
        }



        public static bool operator !=(dcom a, dcom b)
        {
            return !(a == b);
        }
        public static bool operator ==(dcom a, dcom b)
        {
            if (!(a is null) && b is null)
                return false;
            if (a is null && !(b is null))
                return false;
            if (a is null && b is null)
                return true;
            return scalar.isClose(a.real, b.real) && scalar.isClose(a.imaginary, b.imaginary);
        }
        public static dmat2 convertToRotationMatrix(dcom a)
        {
            dmat2 output = new dmat2();
            output.setValue(0, 0, (double)Math.Cos(a.argument));
            output.setValue(0, 1, (double)-Math.Sin(a.argument));
            output.setValue(1, 0, (double)Math.Sin(a.argument));
            output.setValue(1, 1, (double)Math.Cos(a.argument));
            return output;
        }
    }
}
#endif
#endif