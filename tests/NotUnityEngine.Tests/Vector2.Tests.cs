using System.Reflection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using UnityEngine;

namespace UnityEngineTests
{
    [TestFixture]
    public class Vector2Tests
    {
        [Test]
        public void Vector2_zero()
        {
            Vector2 zv = Vector2.zero;
            Assert.That(zv.x, Is.Zero);
            Assert.That(zv.y, Is.Zero);
        }

        [Test]
        public void Vector2_equals()
        {
            Vector2 v1 = new Vector2(1,2);
            Vector2 v2 = new Vector2(3,4);
            Vector2 v3 = new Vector2(1,2);
            Vector3 v4 = new Vector3(5,6,7);

            Assert.That(v1.Equals(v2), Is.False);
            Assert.That(v1.Equals(v3), Is.True);
            Assert.That(v1.Equals(v2 as object), Is.False);
            Assert.That(v1.Equals(v3 as object), Is.True);
            Assert.That(v1.Equals(v4), Is.False);
            Assert.That(v1, Is.Not.EqualTo(v2));
            Assert.That(v1, Is.EqualTo(v3));
            Assert.That(v1 == v2, Is.False);
            Assert.That(v1 != v2, Is.True);
            Assert.That(v1 == v3, Is.True);
            Assert.That(v1 != v3, Is.False);
        }

        [Test]
        public void Vector2_GetHashCode()
        {
            Vector2 v1 = new Vector2(1,2);
            Vector2 v3 = new Vector2(1,2);
            // Note that GetHashCode does NOT require different objects to have different hashes.
            // Only that equivalent objects have the same
            Assert.That(v1.GetHashCode(), Is.EqualTo(v3.GetHashCode()));
        }

        [Test]
        public void Vector2_copy_ctor()
        {
            Vector2 v1 = new Vector2( 123, -456);
            Vector2 v2 = new Vector2(v1);
            Assert.That(v1.x, Is.EqualTo(123));
            Assert.That(v1.y, Is.EqualTo(-456));
            Assert.That(v1.x, Is.EqualTo(v2.x));
            Assert.That(v1.y, Is.EqualTo(v2.y));
        }

        [TestCase(0,0, 0)]
        [TestCase(0,1, 1)]
        [TestCase(3,4, 5)]
        public void Vector2_magnitude(float x, float y, float m)
        {
            Vector2 v = new Vector2(x,y);
            Assert.That(v.magnitude, Is.EqualTo(m));
        }

        [TestCase(0,0,0,0)]
        [TestCase(0,1,0,1)]
        [TestCase(3,4, 0.600000024f, 0.800000012f)]
        [TestCase(-5,9,-0.48564291f,  0.87415725f)]
        public void Vector2_normalized(float x, float y, float nx, float ny)
        {
            Vector2 v = new Vector2(x,y).normalized;
            Assert.That(v.x, Is.EqualTo(nx));
            Assert.That(v.y, Is.EqualTo(ny));
        }

        [TestCase(0,0,0,0)]
        [TestCase(0,1,0,1)]
        [TestCase(3,4, 0.600000024f, 0.800000012f)]
        [TestCase(-5,9,-0.48564291f,  0.87415725f)]
        public void Vector2_Normalize(float x, float y, float nx, float ny)
        {
            Vector2 v = new Vector2(x,y);
            v.Normalize();
            Assert.That(v.x, Is.EqualTo(nx));
            Assert.That(v.y, Is.EqualTo(ny));
        }

        [TestCase(0,0, 0,0, 0,0)]
        [TestCase(6.5f,1, -3,4.2f, 3.5f, 5.2f )]
        [TestCase(132,21f, -4,-5.6f, 128, 15.4f)]
        public void Vector2_addVec(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            Vector2 v1 = new Vector2(x1,y1);
            Vector2 v2 = new Vector2(x2,y2);
            Vector2 v3 = new Vector2(x3,y3);
            Assert.That(v1+v2, Is.EqualTo(v3));
        }

        [TestCase(0,0, 1, 1,1)]
        [TestCase(6.5f,1, -3, 3.5f,-2 )]
        [TestCase(132,21f, 5.6f, 137.6f, 26.6f)]
        public void Vector2_addFloat(float x1, float y1, float val, float x2, float y2)
        {
            Vector2 v1 = new Vector2(x1,y1);
            Vector2 v2 = new Vector2(x2,y2);
            Assert.That(v1+val, Is.EqualTo(v2));
        }

        [TestCase(0,0, 0,0, 0,0)]
        [TestCase(6.5f,1, -3,4.2f, 9.5f, -3.1999998f)]
        [TestCase(132,21f, -4,-5.6f, 136, 26.6f)]
        public void Vector2_subVec(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            Vector2 v1 = new Vector2(x1,y1);
            Vector2 v2 = new Vector2(x2,y2);
            Vector2 v3 = new Vector2(x3,y3);
            Assert.That(v1-v2, Is.EqualTo(v3));
        }

        [TestCase(0,0, 1, -1,-1)]
        [TestCase(6.5f,1, -3, 9.5f, 4 )]
        [TestCase(132,21f, 5.6f, 126.4f, 15.4f)]
        public void Vector2_subFloat(float x1, float y1, float val, float x2, float y2)
        {
            Vector2 v1 = new Vector2(x1,y1);
            Vector2 v2 = new Vector2(x2,y2);
            Assert.That(v1-val, Is.EqualTo(v2));
        }

    }

}