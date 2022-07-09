using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CubeTest.test.CubeBuilder;

namespace CubeTest.test
{
    [TestClass]
    public class CubeCollisionTest
    {

        [TestMethod]
        public void CubesThatDoNotTouch()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(10, 10, 10).WithEdgeLength(2).Build();

            Assert.IsFalse(cubeA.CollidesWith(cubeB));
        }

        [TestMethod]
        public void CubesThatOverlap()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(3, 2, 2).WithEdgeLength(2).Build();

            Assert.IsTrue(cubeA.CollidesWith(cubeB));
        }

        [TestMethod]
        public void CubesThatTouch()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(4, 2, 2).WithEdgeLength(2).Build();

            Assert.IsTrue(cubeA.CollidesWith(cubeB));
        }
    }
}
