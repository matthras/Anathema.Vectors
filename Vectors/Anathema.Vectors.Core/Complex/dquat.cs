﻿#if FLOATS_ENABLED
#if COMPLEX_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    //WARNING: Implementation generated by AI and not tested yet.
    /// <summary>
    /// Double precision floating point quaternion
    /// </summary>
    public class dquat
    {
        public double a { get; set; } // w
        public double b { get; set; } // x
        public double c { get; set; } // y
        public double d { get; set; } // z

        public dquat(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public dquat(double[] abcd)
        {
            this.a = abcd[0];
            this.b = abcd[1];
            this.c = abcd[2];
            this.d = abcd[3];
        }

        public dquat(double eulerX, double eulerY, double eulerZ)
        {
            double cx = Math.Cos(eulerX * 0.5f);
            double sx = Math.Sin(eulerX * 0.5f);
            double cy = Math.Cos(eulerY * 0.5f);
            double sy = Math.Sin(eulerY * 0.5f);
            double cz = Math.Cos(eulerZ * 0.5f);
            double sz = Math.Sin(eulerZ * 0.5f);

            this.a = cx * cy * cz + sx * sy * sz;
            this.b = sx * cy * cz - cx * sy * sz;
            this.c = cx * sy * cz + sx * cy * sz;
            this.d = cx * cy * sz - sx * sy * cz;
        }

        public dquat(mat3 orientation)
        {
            double trace = orientation[0, 0] + orientation[1, 1] + orientation[2, 2];

            if (trace > 0)
            {
                double s = Math.Sqrt(trace + 1.0f) * 2f;
                this.a = 0.25f * s;
                this.b = (orientation[2, 1] - orientation[1, 2]) / s;
                this.c = (orientation[0, 2] - orientation[2, 0]) / s;
                this.d = (orientation[1, 0] - orientation[0, 1]) / s;
            }
            else if ((orientation[0, 0] > orientation[1, 1]) && (orientation[0, 0] > orientation[2, 2]))
            {
                double s = Math.Sqrt(1.0f + orientation[0, 0] - orientation[1, 1] - orientation[2, 2]) * 2f;
                this.a = (orientation[2, 1] - orientation[1, 2]) / s;
                this.b = 0.25f * s;
                this.c = (orientation[0, 1] + orientation[1, 0]) / s;
                this.d = (orientation[0, 2] + orientation[2, 0]) / s;
            }
            else if (orientation[1, 1] > orientation[2, 2])
            {
                double s = Math.Sqrt(1.0f + orientation[1, 1] - orientation[0, 0] - orientation[2, 2]) * 2f;
                this.a = (orientation[0, 2] - orientation[2, 0]) / s;
                this.b = (orientation[0, 1] + orientation[1, 0]) / s;
                this.c = 0.25f * s;
                this.d = (orientation[1, 2] + orientation[2, 1]) / s;
            }
            else
            {
                double s = Math.Sqrt(1.0f + orientation[2, 2] - orientation[0, 0] - orientation[1, 1]) * 2f;
                this.a = (orientation[1, 0] - orientation[0, 1]) / s;
                this.b = (orientation[0, 2] + orientation[2, 0]) / s;
                this.c = (orientation[1, 2] + orientation[2, 1]) / s;
                this.d = 0.25f * s;
            }
        }

        public static dquat slerp(dquat from, dquat to, double t)
        {
            double cosTheta = from.a * to.a + from.b * to.b + from.c * to.c + from.d * to.d;

            if (cosTheta < 0.0f)
            {
                to = new dquat(-to.a, -to.b, -to.c, -to.d);
                cosTheta = -cosTheta;
            }

            if (cosTheta > 0.9995f)
            {
                dquat result = new dquat(
                    from.a + t * (to.a - from.a),
                    from.b + t * (to.b - from.b),
                    from.c + t * (to.c - from.c),
                    from.d + t * (to.d - from.d)
                );
                return normalise(result);
            }

            double angle = Math.Acos(cosTheta);
            double sinTheta = Math.Sqrt(1.0f - cosTheta * cosTheta);

            double w1 = Math.Sin((1 - t) * angle) / sinTheta;
            double w2 = Math.Sin(t * angle) / sinTheta;

            return new dquat(
                w1 * from.a + w2 * to.a,
                w1 * from.b + w2 * to.b,
                w1 * from.c + w2 * to.c,
                w1 * from.d + w2 * to.d
            );
        }

        public dmat3 toMat3()
        {
            double w = a, x = b, y = c, z = d;

            double[] m = new double[9];
            m[0] = 1 - 2 * y * y - 2 * z * z;
            m[1] = 2 * x * y - 2 * z * w;
            m[2] = 2 * x * z + 2 * y * w;

            m[3] = 2 * x * y + 2 * z * w;
            m[4] = 1 - 2 * x * x - 2 * z * z;
            m[5] = 2 * y * z - 2 * x * w;

            m[6] = 2 * x * z - 2 * y * w;
            m[7] = 2 * y * z + 2 * x * w;
            m[8] = 1 - 2 * x * x - 2 * y * y;

            return new dmat3(m);
        }

        public dvec3 toEulerAngles()
        {
            double w = a, x = b, y = c, z = d;

            double sinr_cosp = 2 * (w * x + y * z);
            double cosr_cosp = 1 - 2 * (x * x + y * y);
            double roll = Math.Atan2(sinr_cosp, cosr_cosp);

            double sinp = 2 * (w * y - z * x);
            double pitch = Math.Abs(sinp) >= 1
                ? (Math.PI / 2 * Math.Sign(sinp))
                : Math.Asin(sinp);

            double siny_cosp = 2 * (w * z + x * y);
            double cosy_cosp = 1 - 2 * (y * y + z * z);
            double yaw = Math.Atan2(siny_cosp, cosy_cosp);

            return new dvec3(roll, pitch, yaw);
        }

        private static dquat normalise(dquat q)
        {
            double mag = Math.Sqrt(q.a * q.a + q.b * q.b + q.c * q.c + q.d * q.d);
            return new dquat(q.a / mag, q.b / mag, q.c / mag, q.d / mag);
        }
    }
}

#endif
#endif
#endif