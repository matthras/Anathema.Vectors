﻿#if DOUBLES_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double precision floating point, 2-component vector.
    /// </summary>
    public class dvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public double x { get; set; }
        public double y { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dvec2()
        {
        }

        public dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public dvec2(dvec2 xy)
        {
            x = xy.x;
            y = xy.y;
        }
        public dvec2(fvec2 xy)
        {
            x = xy.x;
            y = xy.y;
        }
        public dvec2(double[] xy)
        {
            this[0] = xy[0];
            this[1] = xy[1];
        }

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////


        public static dvec2 fromAngleRadians(double angle)
        {
            return new dvec2(Math.Cos(angle - (Math.PI / 2)), Math.Sin(angle - (Math.PI / 2)));
        }
        public static dvec2 fromAngleRadiansAndLength(double angle, double length)
        {
            return new dvec2(fromAngleRadians(angle) * length);
        }
        public static dvec2 fromAngleDegrees(double angle)
        {
            return fromAngleRadians(angle * (Math.PI / 180.0f));
        }
        public static dvec2 fromAngleDegreesAndLength(double angle, double length)
        {
            return fromAngleRadiansAndLength(angle * (Math.PI / 180.0f), length);
        }

        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        public double angleRadians
        {
            get
            {
                return Math.Atan2(y, x) + (Math.PI / 2);
            }
        }
        public double angleDegrees
        {
            get
            {
                return angleRadians * (180.0f / Math.PI);
            }
        }

        public virtual double length
        {
            get
            {
                return Math.Sqrt((x * x) + (y * y));
            }
        }
        public dvec2 normalised
        {
            get
            {
                return this / length;
            }
        }


        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        public virtual void normalise()
        {
            double f = length;
            x /= f;
            y /= f;
        }

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

#if SWIZZLES_ENABLED
        public dvec2 xy
        {
            get
            {
                return new dvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public dvec2 yx
        {
            get
            {
                return new dvec2(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
#endif

#if COLOURS_ENABLED
        public double r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public dvec2 rg
        {
            get
            {
                return new dvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public dvec2 gr
        {
            get
            {
                return new dvec2(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
#endif
        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public double dot(dvec2 b)
        {
            return dot(this, b);
        }
        public static double dot(dvec2 a, dvec2 b)
        {
            return (a.x * b.x) + (a.y * b.y);
        }

        public dvec2 cross()
        {
            return cross(this);
        }
        public static dvec2 cross(dvec2 a)
        {
            return new dvec2(a.y, a.x);
        }


        public static bool operator !=(dvec2 a, dvec2 b)
        {
            return !(a == b);
        }
        public static bool operator ==(dvec2 a, dvec2 b)
        {
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y);
        }


        public static dvec2 operator *(dvec2 a, dvec2 b)
        {
            return new dvec2(a.x * b.x, a.y * b.y);
        }
        public static dvec2 operator /(dvec2 a, dvec2 b)
        {
            return new dvec2(a.x / b.x, a.y / b.y);
        }
        public static dvec2 operator +(dvec2 a, dvec2 b)
        {
            return new dvec2(a.x + b.x, a.y + b.y);
        }
        public static dvec2 operator -(dvec2 a, dvec2 b)
        {
            return new dvec2(a.x - b.x, a.y - b.y);
        }


#if CONVERSIONS_ENABLED
        public static dvec2 operator *(fvec2 a, dvec2 b)
        {
            return new dvec2(a.x * b.x, a.y * b.y);
        }
        public static dvec2 operator /(fvec2 a, dvec2 b)
        {
            return new dvec2(a.x / b.x, a.y / b.y);
        }
        public static dvec2 operator +(fvec2 a, dvec2 b)
        {
            return new dvec2(a.x + b.x, a.y + b.y);
        }
        public static dvec2 operator -(fvec2 a, dvec2 b)
        {
            return new dvec2(a.x - b.x, a.y - b.y);
        }



        public static dvec2 operator *(dvec2 a, fvec2 b)
        {
            return new dvec2(a.x * b.x, a.y * b.y);
        }
        public static dvec2 operator /(dvec2 a, fvec2 b)
        {
            return new dvec2(a.x / b.x, a.y / b.y);
        }
        public static dvec2 operator +(dvec2 a, fvec2 b)
        {
            return new dvec2(a.x + b.x, a.y + b.y);
        }
        public static dvec2 operator -(dvec2 a, fvec2 b)
        {
            return new dvec2(a.x - b.x, a.y - b.y);
        }
#endif



        public static dvec2 operator *(dvec2 a, double b)
        {
            return new dvec2(a.x * b, a.y * b);
        }
        public static dvec2 operator /(dvec2 a, double b)
        {
            return new dvec2(a.x / b, a.y / b);
        }
        public static dvec2 operator +(dvec2 a, double b)
        {
            return new dvec2(a.x + b, a.y + b);
        }
        public static dvec2 operator -(dvec2 a, double b)
        {
            return new dvec2(a.x - b, a.y - b);
        }



        public static dvec2 operator *(double b, dvec2 a)
        {
            return new dvec2(a.x * b, a.y * b);
        }
        public static dvec2 operator /(double b, dvec2 a)
        {
            return new dvec2(b / a.x, b / a.y);
        }
        public static dvec2 operator +(double b, dvec2 a)
        {
            return new dvec2(a.x + b, a.y + b);
        }
        public static dvec2 operator -(double b, dvec2 a)
        {
            return new dvec2(b - a.x, b - a.y);
        }
        public static dvec2 operator -(dvec2 a)
        {
            return new dvec2(-a.x, -a.y);
        }


        public static dvec2 operator *(dvec2 a, dmat2 b)
        {
            return new dvec2((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)),
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
        public static dvec2 operator *(dmat2 b, dvec2 a)
        {
            return a * b.transposed;
        }
#if CONVERSIONS_ENABLED
        public static dvec2 operator *(dvec2 a, fmat2 b)
        {
            return new dvec2((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)),
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
        public static dvec2 operator *(fmat2 b, dvec2 a)
        {
            return a * b.transposed;
        }
#endif
#if NESTING_ENABLED
        public static dvec2 operator *(dvec2 a, tvec2<tvec2<double>> b)
        {
            dmat2 matrix = dmat2.fromNestedVector(b);

            return a * matrix;
        }
        public static dvec2 operator *(tvec2<tvec2<double>> b, dvec2 a)
        {
            dmat2 matrix = dmat2.fromNestedVector(b);

            return a * matrix.transposed;
        }

#endif
        public double this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1)
                    return y;
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i == 0)
                { x = value; return; }
                if (i == 1)
                { y = value; return; }
                throw new IndexOutOfRangeException();
            }
        }

        public virtual double[] ToArray()
        {
            return new double[] { x, y };
        }


#if CONVERSIONS_ENABLED
#if TEMPLATES_ENABLED
        public tvec2<double> toTVec2()
        {
            return new tvec2<double>(x, y);
        }
#endif
#endif

        ///////////////////////////
        //     Interpolation     //
        ///////////////////////////
#if INTERPOLATION_ENABLED
        public static dvec2 linearInterpolate(dvec2 a, dvec2 b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public dvec2 linearInterpolateTo(dvec2 b, double position)
        {
            return linearInterpolate(this, b, position);
        }
        public static dvec2 quadraticBezierInterpolate(dvec2 a, dvec2 b, dvec2 c, double position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public dvec2 quadraticBezierInterpolateTo(dvec2 b, dvec2 c, double position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


        //todo: validate this
        public static dvec2 cubicBezierInterpolate(dvec2 a, dvec2 b, dvec2 c, dvec2 d, double position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public dvec2 cubicBezierInterpolateTo(dvec2 b, dvec2 c, dvec2 d, double position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }



        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
#endif