﻿using HW4.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4.Tests.Facade.Quantity
{
    [TestClass]
    public class MeasureTermViewTests : SealedClassTests<MeasureTermView, CommonTermView>
    {
        [TestMethod] public void MasterIdTest() => isNullableProperty(() => obj.MasterId, x => obj.MasterId = x);

        [TestMethod] public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.MasterId}.{obj.TermId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
