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

        [TestCase(0,0, 0)]
        [TestCase(0,1, 1)]
        [TestCase(3,4, 5)]
        public void Vector2_magnitude(float x, float y, float m)
        {
            Vector2 v = new Vector2(x,y);
            Assert.That(v.magnitude, Is.EqualTo(m));
        }
    }

}