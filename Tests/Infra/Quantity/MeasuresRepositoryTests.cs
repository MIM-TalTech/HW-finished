using System;
using HW4.Aids;
using HW4.Data.Quantity;
using HW4.Domain.Quantity;
using HW4.Infra;
using HW4.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4.Tests.Infra.Quantity
{
    [TestClass]
    public class MeasuresRepositoryTests : RepositoryTests<MeasuresRepository, Measure, MeasureData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<QuantityDbContext>().UseInMemoryDatabase("TestDb").Options;
            db = new QuantityDbContext(options);
            dbSet = ((QuantityDbContext)db).Measures;
            obj = new MeasuresRepository((QuantityDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType()
        {
            return typeof(UniqueEntityRepository<Measure, MeasureData>);
        }

        protected override string getId(MeasureData d) => d.Id;

        protected override Measure getObject(MeasureData d) => new Measure(d);

        protected override void setId(MeasureData d, string id) => d.Id = id;
    }
}
