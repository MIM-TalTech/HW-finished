using System;
using HW4.Aids;
using HW4.Data.Quantity;
using HW4.Domain.Quantity;
using HW4.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4.Tests.Facade.Quantity
{
    [TestClass]
    public class UnitViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(UnitViewFactory);
        }


        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<UnitView>();
            var data = UnitViewFactory.Create(view).Data;
            testArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<UnitData>();
            var view = UnitViewFactory.Create(new Unit(data));
            testArePropertyValuesEqual(view, data);
        }
    }
}
