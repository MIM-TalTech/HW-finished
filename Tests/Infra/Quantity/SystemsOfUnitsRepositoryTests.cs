﻿using System;
using HW4.Data.Quantity;
using HW4.Domain.Quantity;
using HW4.Infra;
using HW4.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4.Tests.Infra.Quantity
{
    [TestClass]
    public class SystemsOfUnitsRepositoryTests : RepositoryTests<SystemsOfUnitsRepository, SystemOfUnits, SystemOfUnitsData>
    {

        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new QuantityDbContext(options);
            dbSet = ((QuantityDbContext)db).SystemsOfUnits;
            obj = new SystemsOfUnitsRepository((QuantityDbContext)db);
            base.TestInitialize();
        }


        protected override Type getBaseType()
        {
            return typeof(UniqueEntityRepository<SystemOfUnits, SystemOfUnitsData>);
        }

        protected override string getId(SystemOfUnitsData d) => d.Id;

        protected override SystemOfUnits getObject(SystemOfUnitsData d) => new SystemOfUnits(d);

        protected override void setId(SystemOfUnitsData d, string id) => d.Id = id;

    }

}