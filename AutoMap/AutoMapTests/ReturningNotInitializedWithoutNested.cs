using AutoMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoMapTests
{
    [TestClass]
    public class ReturningNotInitializedWithoutNested
    {
        [TestMethod]
        [ExpectedException(typeof(NullSourceException))]
        public void MapCarNullToCar()
        {
            Car car = null;
            var autoMap = new AutoMapper();
            autoMap.DoMapping<Car, Car>(car);
        }


        [TestMethod]
        [ExpectedException(typeof(NullSourceException))]
        public void MapCarNullToTruck()
        {
            Car car = null;
            var truck = new Truck();
            var autoMap = new AutoMapper();
            autoMap.DoMapping<Car, Truck>(car, truck);
        }
    }
}