﻿using HW4.Aids;
using HW4.Data.Quantity;
using HW4.Domain.Quantity;
using HW4.Facade.Quantity;
using HW4.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4.Tests.Pages {

    [TestClass]
    public class CommonPageTests
        : AbstractPageTests<CommonPage<IMeasuresRepository, Measure, MeasureView, MeasureData>
            , PaginatedPage<IMeasuresRepository, Measure, MeasureView, MeasureData>> {
       
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass(new testRepository());
        }

        [TestMethod] public void ItemIdTest() {
            obj.Item = GetRandom.Object<MeasureView>();
            Assert.AreEqual(obj.Item.Id, obj.ItemId);
        }

        [TestMethod] public void PageTitleTest() {
            isNullableProperty(()=> obj.PageTitle, x => obj.PageTitle = x);
        }

        [TestMethod] public void PageSubTitleTest() {
            isReadOnlyProperty(obj, nameof(obj.PageSubTitle), obj.getPageSubTitle());
        }

        [TestMethod] public void GetPageSubtitleTest() {
            Assert.AreEqual(obj.PageSubTitle, obj.getPageSubTitle());
        }

        [TestMethod] public void PageUrlTest() {
            isReadOnlyProperty(obj, nameof(obj.PageUrl), obj.getPageUrl());
        }

        [TestMethod] public void GetPageUrlTest() {
            Assert.AreEqual(obj.PageUrl, obj.getPageUrl());
        }

        [TestMethod] public void IndexUrlTest() {
            isReadOnlyProperty(obj, nameof(obj.IndexUrl), obj.getIndexUrl());
        }

        [TestMethod] public void GetIndexUrlTest() {
            Assert.AreEqual(obj.IndexUrl, obj.getIndexUrl());
        }

    }

}
