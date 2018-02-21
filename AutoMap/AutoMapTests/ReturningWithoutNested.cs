using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMap;

namespace AutoMapTests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void MapAccomodationToAccomodation()
        {
            var accomodation = new Accomodation() { number = 302, street = "stusa"};

            var accomodationExpectedMapped = new Accomodation() { number = 302, street = "stusa" };
            var autoMap = new AutoMapper();
            var accomodationActualMapped = autoMap.DoMapping<Accomodation, Accomodation>(accomodation);

            Assert.IsTrue(accomodationExpectedMapped.number == accomodationActualMapped.number && accomodationExpectedMapped.street == accomodationActualMapped.street);
        }


        [TestMethod]
        public void MapAccomodationToFlat()
        {
            var accomodation = new Accomodation() { number = 302, street = "stusa" };
            var flat = new Flat();
            var accomodationExpectedMapped = new Accomodation() { number = 302, street = "stusa" };
            var autoMap = new AutoMapper();
            var flatActualMapped = autoMap.DoMapping<Accomodation, Flat>(accomodation, flat);

            Assert.IsTrue(accomodationExpectedMapped.number == flatActualMapped.Number && accomodationExpectedMapped.street == flatActualMapped.Street);
        }
    }
}
