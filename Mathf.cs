using System;

namespace UnityEngine
{
    public static class Mathf
    {
        // ReSharper disable MemberCanBePrivate.Global,UnusedMember.Global,FieldCanBeMadeReadOnly.Global,InconsistentNaming
        public const float PI = 3.1415926535897932384626433832795028841971693993751058209749445923078164062f;
        public const float DegToRad = (PI * 2f) / 360f;
        public const float RadToDeg = 360f / (PI * 2f);
        public static float Sign(float x) => x < 0 ? -1f : 1f; // WATCH OUT! This is NOT the signum function, where sgn(0) = 0
        public static float Min(float a, float b) => (float)Math.Min(a,b);
        public static float Max(float a, float b) => (float)Math.Max(a,b);
        public static float Floor(float a) => (float)Math.Floor(a);

        public static float Round(float a) => (float)Math.Round(a);
        public static float Square(float a) => (float)(a*a);

        public static float Clamp(float x, float min, float max) => (x < min) ? min : ((x > max) ? max : x);
    }
}
