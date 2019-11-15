using System.Diagnostics;
using System;

namespace UnityEngine
{
    public struct Vector2 : IEquatable<Vector2>
    {

        // fields
        private static Vector2 zeroVector = new Vector2(0f, 0f);

        public float x;
        public float y;        

        // properties
        public static Vector2 zero { get { return zeroVector; }}

        public float magnitude {get {return (float)Math.Sqrt(x*x + y*y);}}     
        public Vector2 normalized {get {return this._doNormalize();} }     

        // ctors
        public Vector2(float _x, float _y) { x=_x; y=_y; }       
        public Vector2(Vector2 v) { x=v.x; y=v.y;}         

        // IEquatable
        public override int GetHashCode() => x.GetHashCode() + y.GetHashCode();

        public override bool Equals(object obj)
        {
            if(obj is Vector2)
                return Equals((Vector2)this);
            return false;
        }        
        public bool Equals(Vector2 other) => (x == other.x && y == other.y);


        // Static Operators
        public static bool operator ==(Vector2 v1, Vector2 v2) =>  v1.x == v2.y && v1.y == v2.y;
        public static bool operator !=(Vector2 v1, Vector2 v2) => v1.x != v2.x || v1.y != v2.y; 
        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.x+b.x, a.y+b.y); 
        public static Vector2 operator +(Vector2 a, float f) => new Vector2(a.x+f, a.y+f); 
        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.x-b.x, a.y-b.y); 
        public static Vector2 operator -(Vector2 a, float f) => new Vector2(a.x-f, a.y-f);         
        public static Vector2 operator *(Vector2 a, float f) => new Vector2(a.x*f, a.y*f);

        // Instance funcs
       private Vector2 _doNormalize()
        {
            float mag = magnitude;
            float scale = mag > 0 ? 1.0f / magnitude : 0;
            return this * scale;         
        }        
        public void Normalize()
        {
            float mag = magnitude;
            float scale = mag > 0 ? 1.0f / magnitude : 0;
            this.x *= scale;
            this.y *= scale; 
        }

        // Static funcs
        public static float Distance(Vector2 a, Vector2 b) => (float)Math.Sqrt(Mathf.Square(b.x-a.x) + Mathf.Square(b.y-a.y));      
        public static float Dot(Vector2 a, Vector2 b) => (float)(a.x * b.x) + (a.y * b.y);
        public static float Cross(Vector2 a, Vector2 b) => (float)(a.x * b.y) - (a.y * b.x);

        // public static float SignedAngle(Vector2 from, Vector2 to)
        // {
        //     //  DEGREES!
        //     if (from == zero || to == zero )
        //         return 0f;            
        //     Vector2 fromN = from.normalized;
        //     Vector2 toN = to.normalized;
        //     float dot = Vector2.Dot(fromN, toN);
        //     return (float)Math.Acos(dot) * -Mathf.Sign(dot) * Mathf.RadToDeg;
        // }

        public static float SignedAngle(Vector2 from, Vector2 to)
        {
            return (float)Math.Atan2(Vector2.Cross(from, to), Vector2.Dot(from, to)) * Mathf.RadToDeg;
        }

    }
}
