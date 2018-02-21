using AutoMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AutoMapTests.CoupleOfNEstedClasses;

namespace AutoMapTests
{
    [TestClass]
   public class ThreeNestedMapCheck
    {
        /// <summary>
        /// Unit test to verify the valid mapping and equal data of nested-nested class
        /// </summary>
        [TestMethod]
        public void PlaneToPlane()
        {
            var plane = new Plane() { Type = "boeing", Model = "737", onBoard = new Plane.OnBoard() {CoupleOfChairs = 258, LightObj = new Plane.OnBoard.Light() {LightPower = 200} } };

            var planeExpectedMapped = new Plane() { Type = "boeing", Model = "737", onBoard = new Plane.OnBoard() { CoupleOfChairs = 258, LightObj = new Plane.OnBoard.Light() { LightPower = 200 } } };
            var autoMap = new AutoMapper();
            var planeActualMapped = autoMap.DoMapping<Plane, Plane>(plane);

            Assert.IsTrue(planeExpectedMapped.Type == planeActualMapped.Type &&
                planeExpectedMapped.Model == planeActualMapped.Model &&
                planeExpectedMapped.onBoard.CoupleOfChairs == planeActualMapped.onBoard.CoupleOfChairs &&
                planeExpectedMapped.onBoard.LightObj.LightPower == planeActualMapped.onBoard.LightObj.LightPower);
        }
    }
}
