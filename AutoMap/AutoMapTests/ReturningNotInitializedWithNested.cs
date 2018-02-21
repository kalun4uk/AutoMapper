using AutoMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoMapTests
{
    [TestClass]
    public class ReturningNotInitializedWithNested
    {
        [TestMethod]
        [ExpectedException(typeof(NullSourceException))]
        public void MapCarToCar()
        {
            Car car = null;
            var autoMap = new AutoMapper();
            autoMap.DoMapping<Car, Car>(car);
        }


        [TestMethod]
        [ExpectedException(typeof(NullSourceException))]
        public void MapCarToTruck()
        {
            Car car = null;
            var truck = new Truck();
            var autoMap = new AutoMapper();
            autoMap.DoMapping<Car, Truck>(car, truck);
        }
    }
}
