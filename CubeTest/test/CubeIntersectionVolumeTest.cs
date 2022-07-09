using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CubeTest.test.CubeBuilder;

namespace CubeTest.test
{
    [TestClass]
    public class CubeIntersectionVolumeTest
    {
        [TestMethod]
        public void CubesThatDoNotIntersect()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(10, 10, 10).WithEdgeLength(2).Build();

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void CubesWithSameHeightAndDepth()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(3, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void CubesWithSameWidthAndDepth()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 3, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void CubesWithSameWidthAndHeight()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 3).WithEdgeLength(2).Build();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void OneCubeIsContainedWithinTheOther()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 2).WithEdgeLength(1).Build();

            Assert.AreEqual(1, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void CubesAreOverlapped()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(8, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void CubesAreTouchingButNotIntersecting()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(4, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
        }

        [TestMethod]
        public void IsCommutative()
        {
            var cubeA = Cube().CenteredAt(0, 0, 0).WithEdgeLength(3).Build();
            var cubeB = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();

            Assert.AreEqual(cubeA.IntersectionVolumeWith(cubeB), cubeB.IntersectionVolumeWith(cubeA));
        }
    }
}
