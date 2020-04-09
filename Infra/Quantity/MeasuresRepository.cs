using HW4.Data.Quantity;
using HW4.Domain.Quantity;

namespace HW4.Infra.Quantity {

    public sealed class MeasuresRepository : UniqueEntityRepository<Measure, MeasureData>, IMeasuresRepository {

        public MeasuresRepository(QuantityDbContext c) : base(c, c.Measures) { }

        protected internal override Measure toDomainObject(MeasureData d) => new Measure(d);

    }

}
