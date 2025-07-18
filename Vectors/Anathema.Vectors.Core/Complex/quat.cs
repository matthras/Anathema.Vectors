﻿#if FLOATS_ENABLED
#if COMPLEX_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    //WARNING: Implementation generated by AI and not tested yet.
    /// <summary>
    /// Single precision floating point quaternion
    /// </summary>
    public class quat
    {
        public float a { get; set; } // w
        public float b { get; set; } // x
        public float c { get; set; } // y
        public float d { get; set; } // z

        public quat(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public quat(float[] abcd)
        {
            this.a = abcd[0];
            this.b = abcd[1];
            this.c = abcd[2];
            this.d = abcd[3];
        }

        public quat(float eulerX, float eulerY, float eulerZ)
        {
            float cx = (float)Math.Cos(eulerX * 0.5f);
            float sx = (float)Math.Sin(eulerX * 0.5f);
            float cy = (float)Math.Cos(eulerY * 0.5f);
            float sy = (float)Math.Sin(eulerY * 0.5f);
            float cz = (float)Math.Cos(eulerZ * 0.5f);
            float sz = (float)Math.Sin(eulerZ * 0.5f);

            this.a = cx * cy * cz + sx * sy * sz;
            this.b = sx * cy * cz - cx * sy * sz;
            this.c = cx * sy * cz + sx * cy * sz;
            this.d = cx * cy * sz - sx * sy * cz;
        }

        public quat(mat3 orientation)
        {
            float trace = orientation[0, 0] + orientation[1, 1] + orientation[2, 2];

            if (trace > 0)
            {
                float s = (float)Math.Sqrt(trace + 1.0f) * 2f;
                this.a = 0.25f * s;
                this.b = (orientation[2, 1] - orientation[1, 2]) / s;
                this.c = (orientation[0, 2] - orientation[2, 0]) / s;
                this.d = (orientation[1, 0] - orientation[0, 1]) / s;
            }
            else if ((orientation[0, 0] > orientation[1, 1]) && (orientation[0, 0] > orientation[2, 2]))
            {
                float s = (float)Math.Sqrt(1.0f + orientation[0, 0] - orientation[1, 1] - orientation[2, 2]) * 2f;
                this.a = (orientation[2, 1] - orientation[1, 2]) / s;
                this.b = 0.25f * s;
                this.c = (orientation[0, 1] + orientation[1, 0]) / s;
                this.d = (orientation[0, 2] + orientation[2, 0]) / s;
            }
            else if (orientation[1, 1] > orientation[2, 2])
            {
                float s = (float)Math.Sqrt(1.0f + orientation[1, 1] - orientation[0, 0] - orientation[2, 2]) * 2f;
                this.a = (orientation[0, 2] - orientation[2, 0]) / s;
                this.b = (orientation[0, 1] + orientation[1, 0]) / s;
                this.c = 0.25f * s;
                this.d = (orientation[1, 2] + orientation[2, 1]) / s;
            }
            else
            {
                float s = (float)Math.Sqrt(1.0f + orientation[2, 2] - orientation[0, 0] - orientation[1, 1]) * 2f;
                this.a = (orientation[1, 0] - orientation[0, 1]) / s;
                this.b = (orientation[0, 2] + orientation[2, 0]) / s;
                this.c = (orientation[1, 2] + orientation[2, 1]) / s;
                this.d = 0.25f * s;
            }
        }

        public static quat slerp(quat from, quat to, float t)
        {
            float cosTheta = from.a * to.a + from.b * to.b + from.c * to.c + from.d * to.d;

            if (cosTheta < 0.0f)
            {
                to = new quat(-to.a, -to.b, -to.c, -to.d);
                cosTheta = -cosTheta;
            }

            if (cosTheta > 0.9995f)
            {
                quat result = new quat(
                    from.a + t * (to.a - from.a),
                    from.b + t * (to.b - from.b),
                    from.c + t * (to.c - from.c),
                    from.d + t * (to.d - from.d)
                );
                return normalise(result);
            }

            float angle = (float)Math.Acos(cosTheta);
            float sinTheta = (float)Math.Sqrt(1.0f - cosTheta * cosTheta);

            float w1 = (float)Math.Sin((1 - t) * angle) / sinTheta;
            float w2 = (float)Math.Sin(t * angle) / sinTheta;

            return new quat(
                w1 * from.a + w2 * to.a,
                w1 * from.b + w2 * to.b,
                w1 * from.c + w2 * to.c,
                w1 * from.d + w2 * to.d
            );
        }

        public mat3 toMat3()
        {
            float w = a, x = b, y = c, z = d;

            float[] m = new float[9];
            m[0] = 1 - 2 * y * y - 2 * z * z;
            m[1] = 2 * x * y - 2 * z * w;
            m[2] = 2 * x * z + 2 * y * w;

            m[3] = 2 * x * y + 2 * z * w;
            m[4] = 1 - 2 * x * x - 2 * z * z;
            m[5] = 2 * y * z - 2 * x * w;

            m[6] = 2 * x * z - 2 * y * w;
            m[7] = 2 * y * z + 2 * x * w;
            m[8] = 1 - 2 * x * x - 2 * y * y;

            return new mat3(m);
        }

        public vec3 toEulerAngles()
        {
            float w = a, x = b, y = c, z = d;

            float sinr_cosp = 2 * (w * x + y * z);
            float cosr_cosp = 1 - 2 * (x * x + y * y);
            float roll = (float)Math.Atan2(sinr_cosp, cosr_cosp);

            float sinp = 2 * (w * y - z * x);
            float pitch = Math.Abs(sinp) >= 1
                ? (float)(Math.PI / 2 * Math.Sign(sinp))
                : (float)Math.Asin(sinp);

            float siny_cosp = 2 * (w * z + x * y);
            float cosy_cosp = 1 - 2 * (y * y + z * z);
            float yaw = (float)Math.Atan2(siny_cosp, cosy_cosp);

            return new vec3(roll, pitch, yaw);
        }

        private static quat normalise(quat q)
        {
            float mag = (float)Math.Sqrt(q.a * q.a + q.b * q.b + q.c * q.c + q.d * q.d);
            return new quat(q.a / mag, q.b / mag, q.c / mag, q.d / mag);
        }
    }
}
#endif
#endif
#endif