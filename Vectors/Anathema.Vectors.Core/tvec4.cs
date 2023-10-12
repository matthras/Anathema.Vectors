﻿#if TEMPLATES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A 4-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public class tvec4<T> : tvec3<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T w { get; set; }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public tvec4()
        {
        }
        public tvec4(tvec3<T> xyz, T w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        public tvec4(T x, tvec3<T> yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public tvec4(tvec2<T> xy, tvec2<T> zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public tvec4(T x, T y, tvec2<T> zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public tvec4(T x, tvec2<T> yz, T w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public tvec4(tvec2<T> xy, T z, T w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        public tvec4(T x, T y, T z, T w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public tvec4(tvec4<T> xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }
        public tvec4(T[] xyzw)
        {
            this.x = xyzw[0];
            this.y = xyzw[1];
            this.z = xyzw[2];
            this.w = xyzw[3];
        }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

#if SWIZZLES_ENABLED
        public tvec4<T> xyzw
        {
            get
            {
                return new tvec4<T>(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public tvec4<T> xwzy
        {
            get
            {
                return new tvec4<T>(x, w, z, y);
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public tvec4<T> xwyz
        {
            get
            {
                return new tvec4<T>(x, w, y, z);
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        public tvec4<T> xywz
        {
            get
            {
                return new tvec4<T>(x, y, w, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public tvec4<T> xzyw
        {
            get
            {
                return new tvec4<T>(x, z, y, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public tvec4<T> xzwy
        {
            get
            {
                return new tvec4<T>(x, z, w, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }





        //Starting with Y (6)

        public tvec4<T> yxzw
        {
            get
            {
                return new tvec4<T>(y, x, z, w);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public tvec4<T> yxwz
        {
            get
            {
                return new tvec4<T>(y, x, w, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public tvec4<T> yzxw
        {
            get
            {
                return new tvec4<T>(y, z, x, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public tvec4<T> yzwx
        {
            get
            {
                return new tvec4<T>(y, z, w, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public tvec4<T> ywzx
        {
            get
            {
                return new tvec4<T>(y, w, z, x);
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public tvec4<T> ywxz
        {
            get
            {
                return new tvec4<T>(y, w, x, z);
            }
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }



        //Starting with Z (6)

        public tvec4<T> zxyw
        {
            get
            {
                return new tvec4<T>(z, x, y, w);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public tvec4<T> zyxw
        {
            get
            {
                return new tvec4<T>(z, y, x, w);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public tvec4<T> zywx
        {
            get
            {
                return new tvec4<T>(z, y, w, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public tvec4<T> zxwy
        {
            get
            {
                return new tvec4<T>(z, x, w, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        public tvec4<T> zwxy
        {
            get
            {
                return new tvec4<T>(z, w, x, y);
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public tvec4<T> zwyx
        {
            get
            {
                return new tvec4<T>(z, w, y, x);
            }
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }



        //Starting with W (6)

        public tvec4<T> wxyz
        {
            get
            {
                return new tvec4<T>(w, x, y, z);
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        public tvec4<T> wxzy
        {
            get
            {
                return new tvec4<T>(w, x, z, y);
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public tvec4<T> wyxz
        {
            get
            {
                return new tvec4<T>(w, y, x, z);
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        public tvec4<T> wyzx
        {
            get
            {
                return new tvec4<T>(w, y, z, x);
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public tvec4<T> wzxy
        {
            get
            {
                return new tvec4<T>(w, z, x, y);
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public tvec4<T> wzyx
        {
            get
            {
                return new tvec4<T>(w, z, y, x);
            }
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }

#endif

#if COLOURS_ENABLED
        public T a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }

        // Starting with r

        public tvec4<T> rgba
        {
            get
            {
                return new tvec4<T>(r, g, b, a);
            }
            set
            {
                r = value.r;
                g = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public tvec4<T> rabg
        {
            get
            {
                return new tvec4<T>(r, a, b, g);
            }
            set
            {
                r = value.r;
                a = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public tvec4<T> ragb
        {
            get
            {
                return new tvec4<T>(r, a, g, b);
            }
            set
            {
                r = value.r;
                a = value.g;
                g = value.b;
                b = value.a;
            }
        }
        public tvec4<T> rgab
        {
            get
            {
                return new tvec4<T>(r, g, a, b);
            }
            set
            {
                r = value.r;
                g = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public tvec4<T> rbga
        {
            get
            {
                return new tvec4<T>(r, b, g, a);
            }
            set
            {
                r = value.r;
                b = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public tvec4<T> rbag
        {
            get
            {
                return new tvec4<T>(r, b, a, g);
            }
            set
            {
                r = value.r;
                b = value.g;
                a = value.b;
                g = value.a;
            }
        }





        //Starting with g (6)

        public tvec4<T> grba
        {
            get
            {
                return new tvec4<T>(g, r, b, a);
            }
            set
            {
                g = value.r;
                r = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public tvec4<T> grab
        {
            get
            {
                return new tvec4<T>(g, r, a, b);
            }
            set
            {
                g = value.r;
                r = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public tvec4<T> gbra
        {
            get
            {
                return new tvec4<T>(g, b, r, a);
            }
            set
            {
                g = value.r;
                b = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public tvec4<T> gbar
        {
            get
            {
                return new tvec4<T>(g, b, a, r);
            }
            set
            {
                g = value.r;
                b = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public tvec4<T> gabr
        {
            get
            {
                return new tvec4<T>(g, a, b, r);
            }
            set
            {
                g = value.r;
                a = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public tvec4<T> garb
        {
            get
            {
                return new tvec4<T>(g, a, r, b);
            }
            set
            {
                g = value.r;
                a = value.g;
                r = value.b;
                b = value.a;
            }
        }



        //Starting with b (6)

        public tvec4<T> brga
        {
            get
            {
                return new tvec4<T>(b, r, g, a);
            }
            set
            {
                b = value.r;
                r = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public tvec4<T> bgra
        {
            get
            {
                return new tvec4<T>(b, g, r, a);
            }
            set
            {
                b = value.r;
                g = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public tvec4<T> bgar
        {
            get
            {
                return new tvec4<T>(b, g, a, r);
            }
            set
            {
                b = value.r;
                g = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public tvec4<T> brag
        {
            get
            {
                return new tvec4<T>(b, r, a, g);
            }
            set
            {
                b = value.r;
                r = value.g;
                a = value.b;
                g = value.a;
            }
        }
        public tvec4<T> barg
        {
            get
            {
                return new tvec4<T>(b, a, r, g);
            }
            set
            {
                b = value.r;
                a = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public tvec4<T> bagr
        {
            get
            {
                return new tvec4<T>(b, a, g, r);
            }
            set
            {
                b = value.r;
                a = value.g;
                g = value.b;
                r = value.a;
            }
        }



        //Starting with a (6)

        public tvec4<T> argb
        {
            get
            {
                return new tvec4<T>(a, r, g, b);
            }
            set
            {
                a = value.r;
                r = value.g;
                g = value.b;
                b = value.a;
            }
        }

        public tvec4<T> arbg
        {
            get
            {
                return new tvec4<T>(a, r, b, g);
            }
            set
            {
                a = value.r;
                r = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public tvec4<T> agrb
        {
            get
            {
                return new tvec4<T>(a, g, r, b);
            }
            set
            {
                a = value.r;
                g = value.g;
                r = value.b;
                b = value.a;
            }
        }
        public tvec4<T> agbr
        {
            get
            {
                return new tvec4<T>(a, g, b, r);
            }
            set
            {
                a = value.r;
                g = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public tvec4<T> abrg
        {
            get
            {
                return new tvec4<T>(a, b, r, g);
            }
            set
            {
                a = value.r;
                b = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public tvec4<T> abgr
        {
            get
            {
                return new tvec4<T>(a, b, g, r);
            }
            set
            {
                a = value.r;
                b = value.g;
                g = value.b;
                r = value.a;
            }
        }

#endif
        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

#if NESTING_ENABLED
        public static tvec4<tvec4<double>> fromDMat4(dmat4 input)
        {
            var output = new tvec4<tvec4<double>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);
            output.x.w = input.getValue(0, 3);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);
            output.y.w = input.getValue(1, 3);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);
            output.z.w = input.getValue(2, 3);

            output.w.x = input.getValue(3, 0);
            output.w.y = input.getValue(3, 1);
            output.w.z = input.getValue(3, 2);
            output.w.w = input.getValue(3, 3);

            return output;
        }
        public static tvec4<tvec4<float>> fromFMat4(fmat4 input)
        {
            var output = new tvec4<tvec4<float>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);
            output.x.w = input.getValue(0, 3);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);
            output.y.w = input.getValue(1, 3);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);
            output.z.w = input.getValue(2, 3);

            output.w.x = input.getValue(3, 0);
            output.w.y = input.getValue(3, 1);
            output.w.z = input.getValue(3, 2);
            output.w.w = input.getValue(3, 3);

            return output;
        }

#endif


#if CONVERSIONS_ENABLED
#if FLOATS_ENABLED
        public fvec4 floatTVec4ToFVec4()
        {
            if (typeof(T) != typeof(float))
                throw new ArgumentException();

            float fx = (float)Convert.ChangeType(x, typeof(float));
            float fy = (float)Convert.ChangeType(y, typeof(float));
            float fz = (float)Convert.ChangeType(z, typeof(float));
            float fw = (float)Convert.ChangeType(w, typeof(float));

            return new fvec4(fx, fy, fz, fw);
        }
#endif
#if DOUBLES_ENABLED
        public dvec4 doubleTVec4ToDVec4()
        {
            if (typeof(T) != typeof(double))
                throw new ArgumentException();

            double fx = (double)Convert.ChangeType(x, typeof(double));
            double fy = (double)Convert.ChangeType(y, typeof(double));
            double fz = (double)Convert.ChangeType(z, typeof(double));
            double fw = (double)Convert.ChangeType(w, typeof(double));

            return new dvec4(fx, fy, fz, fw);
        }
#endif
#endif




        public new T this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1)
                    return y;
                if (i == 2)
                    return z;
                if (i == 3)
                    return w;
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i == 0)
                { x = value; return; }
                if (i == 1)
                { y = value; return; }
                if (i == 2)
                { z = value; return; }
                if (i == 3)
                { w = value; return; }
                throw new IndexOutOfRangeException();
            }
        }



        public override T[] ToArray()
        {
            return new T[] { x, y, z, w };
        }







#if TEMPLATE_OPERATIONS_ENABLED

        public static bool operator !=(tvec4<T> a, tvec4<T> b)
        {
            return !(a == b);
        }
        public static bool operator ==(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by) && scalar.isClose(az, bz) && scalar.isClose(aw, bw);
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by) && scalar.isClose(az, bz) && scalar.isClose(aw, bw);
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator *(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz), floatToT(aw * bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz), doubleToT(aw * bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz), decimalToT(aw * bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)), byteToT((byte)(aw * bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)), shortToT((short)(aw * bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz), intToT(aw * bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz), longToT(aw * bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator /(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz), floatToT(aw / bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz), doubleToT(aw / bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz), decimalToT(aw / bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)), byteToT((byte)(aw / bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)), shortToT((short)(aw / bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz), intToT(aw / bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz), longToT(aw / bw));
            }
            throw new TypeLoadException();
        }


        public static tvec4<T> operator +(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz), floatToT(aw + bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz), doubleToT(aw + bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz), decimalToT(aw + bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)), byteToT((byte)(aw + bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)), shortToT((short)(aw + bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz), intToT(aw + bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz), longToT(aw + bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator -(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz), floatToT(aw - bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz), doubleToT(aw - bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz), decimalToT(aw - bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)), byteToT((byte)(aw - bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)), shortToT((short)(aw - bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz), intToT(aw - bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz), longToT(aw - bw));
            }
            throw new TypeLoadException();
        }









        public static tvec4<T> operator *(tvec4<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                float bw = tToFloat(b);
                return new tvec4<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz), floatToT(aw * bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                double bw = tToDouble(b);
                return new tvec4<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz), doubleToT(aw * bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                decimal bw = tToDecimal(b);
                return new tvec4<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz), decimalToT(aw * bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                byte bw = tToByte(b);
                return new tvec4<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)), byteToT((byte)(aw * bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                short bw = tToShort(b);
                return new tvec4<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)), shortToT((short)(aw * bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                int bw = tToInt(b);
                return new tvec4<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz), intToT(aw * bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                long bw = tToLong(b);
                return new tvec4<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz), longToT(aw * bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator /(tvec4<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                float bw = tToFloat(b);
                return new tvec4<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz), floatToT(aw / bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                double bw = tToDouble(b);
                return new tvec4<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz), doubleToT(aw / bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                decimal bw = tToDecimal(b);
                return new tvec4<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz), decimalToT(aw / bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                byte bw = tToByte(b);
                return new tvec4<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)), byteToT((byte)(aw / bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                short bw = tToShort(b);
                return new tvec4<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)), shortToT((short)(aw / bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                int bw = tToInt(b);
                return new tvec4<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz), intToT(aw / bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                long bw = tToLong(b);
                return new tvec4<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz), longToT(aw / bw));
            }
            throw new TypeLoadException();
        }


        public static tvec4<T> operator +(tvec4<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                float bw = tToFloat(b);
                return new tvec4<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz), floatToT(aw + bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                double bw = tToDouble(b);
                return new tvec4<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz), doubleToT(aw + bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                decimal bw = tToDecimal(b);
                return new tvec4<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz), decimalToT(aw + bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                byte bw = tToByte(b);
                return new tvec4<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)), byteToT((byte)(aw + bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                short bw = tToShort(b);
                return new tvec4<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)), shortToT((short)(aw + bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                int bw = tToInt(b);
                return new tvec4<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz), intToT(aw + bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                long bw = tToLong(b);
                return new tvec4<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz), longToT(aw + bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator -(tvec4<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                float bw = tToFloat(b);
                return new tvec4<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz), floatToT(aw - bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                double bw = tToDouble(b);
                return new tvec4<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz), doubleToT(aw - bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                decimal bw = tToDecimal(b);
                return new tvec4<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz), decimalToT(aw - bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                byte bw = tToByte(b);
                return new tvec4<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)), byteToT((byte)(aw - bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                short bw = tToShort(b);
                return new tvec4<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)), shortToT((short)(aw - bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                int bw = tToInt(b);
                return new tvec4<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz), intToT(aw - bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                long bw = tToLong(b);
                return new tvec4<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz), longToT(aw - bw));
            }
            throw new TypeLoadException();
        }












        public static tvec4<T> operator *(T a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float aw = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz), floatToT(aw * bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double aw = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz), doubleToT(aw * bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal aw = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz), decimalToT(aw * bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte aw = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)), byteToT((byte)(aw * bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short aw = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)), shortToT((short)(aw * bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int aw = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz), intToT(aw * bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long aw = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz), longToT(aw * bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator /(T a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float aw = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz), floatToT(aw / bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double aw = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz), doubleToT(aw / bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal aw = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz), decimalToT(aw / bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte aw = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)), byteToT((byte)(aw / bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short aw = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)), shortToT((short)(aw / bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int aw = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz), intToT(aw / bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long aw = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz), longToT(aw / bw));
            }
            throw new TypeLoadException();
        }


        public static tvec4<T> operator +(T a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float aw = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz), floatToT(aw + bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double aw = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz), doubleToT(aw + bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal aw = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz), decimalToT(aw + bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte aw = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)), byteToT((byte)(aw + bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short aw = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)), shortToT((short)(aw + bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int aw = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz), intToT(aw + bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long aw = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz), longToT(aw + bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator -(T a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float aw = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz), floatToT(aw - bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double aw = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz), doubleToT(aw - bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal aw = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz), decimalToT(aw - bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte aw = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)), byteToT((byte)(aw - bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short aw = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)), shortToT((short)(aw - bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int aw = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz), intToT(aw - bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long aw = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz), longToT(aw - bw));
            }
            throw new TypeLoadException();
        }







#endif
    }
}
#endif
#endif