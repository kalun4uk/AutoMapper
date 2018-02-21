using AutoMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoMapTests
{
    [TestClass]
    public class ReturningWithNested
    {
        /// <summary>
        /// Verification of data validity and equality of the one mapped object as a base of the second created
        /// </summary>
        [TestMethod]
        public void MapCarToCarVerificationWithNested()
        {
            var car = new Car() { Model = 302, name = "BMW", carWheel = new Car.Wheel { Size = 21, name = "BMW" } };

            var carExpectedMapped = new Car { Model = 302, name = "BMW", carWheel = new Car.Wheel { Size = 21, name = "BMW" } };
            var autoMap = new AutoMapper();
            var carActualMapped = autoMap.DoMapping<Car, Car>(car);

            Assert.IsTrue(carExpectedMapped.Model == carActualMapped.Model && carExpectedMapped.name == carActualMapped.name &&
                carExpectedMapped.carWheel.Size == carActualMapped.carWheel.Size && carExpectedMapped.carWheel.name == carActualMapped.carWheel.name);
        }

        /// <summary>
        /// Verification of the equality data of two objects of the different classes with nested classes
        /// </summary>
        [TestMethod]
        public void MapCarToTruckVerificationWithNested()
        {
            var car = new Car() { Model = 302, name = "BMW", carWheel = new Car.Wheel { Size = 21, name = "BMW" } };
            var truck = new Truck();
            var truckExpectedMapped = new Truck { model = 302, name = "BMW", carWheel = new Truck.Wheel { Size = 21, name = "BMW" } };
            var autoMap = new AutoMapper();
            var truckActualMapped = autoMap.DoMapping<Car, Truck>(car, truck);

            Assert.IsTrue(truckExpectedMapped.model == truckActualMapped.model && truckExpectedMapped.name == truckActualMapped.name &&
                truckExpectedMapped.carWheel.Size == truckActualMapped.carWheel.Size && truckExpectedMapped.carWheel.name == truckActualMapped.carWheel.name);
        }
    }
}
