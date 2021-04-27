using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using UnityEngine;

namespace UnityEngineTests
{
    [TestFixture]
    public class Vector3Tests
    {
        // Vector3 does almost nothing at the moment
        [Test]
        public void Vector3_ctor()
        {
            Vector3 v = new Vector3(23,45,-67);;
            Assert.That(v.x, Is.EqualTo(23));
            Assert.That(v.y, Is.EqualTo(45));
            Assert.That(v.z, Is.EqualTo(-67));
        }

    }

}