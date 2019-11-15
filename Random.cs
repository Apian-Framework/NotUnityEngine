using System;

namespace UnityEngine
{
    public class Random
    {
        static System.Random randInst = new System.Random();
        // TODO: seed this
        public static float Range(float low, float high)
        {
            return (float)(randInst.NextDouble() * (high - low) + low);
        }
        
        public static float value { get => (float)randInst.NextDouble(); }      
    }
}
