using AutoMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoMapTests
{
    /// <summary>
    /// Verification unit test of the null sended objects
    /// </summary>
    [TestClass]
    public class NullObjects
    {
        /// <summary>
        /// Null verification of the one sended object of the generic type
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullSourceException))]
        public void NullObjectAccomodation()
        {
            Accomodation accomodation = null;
            var autoMap = new AutoMapper();
            autoMap.DoMapping<Accomodation, Accomodation>(accomodation);
        }

        /// <summary>
        /// Null verification of the first null-object and the second not null object
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullSourceException))]
        public void ObjectHasNoDataObjects()
        {
            Accomodation accomodation = null;
            Flat flat = new Flat();
            var autoMap = new AutoMapper();
            autoMap.DoMapping<Accomodation, Flat>(accomodation, flat);
        }
    }
}