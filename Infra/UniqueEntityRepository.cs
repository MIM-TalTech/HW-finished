﻿using System.Threading.Tasks;
using HW4.Data.Common;
using HW4.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace HW4.Infra {

    public abstract class UniqueEntityRepository<TDomain, TData> : PaginatedRepository<TDomain, TData>
        where TData : UniqueEntityData, new()
        where TDomain : Entity<TData>, new() {

        protected UniqueEntityRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        protected override async Task<TData> getData(string id)
            => await dbSet.FirstOrDefaultAsync(m => m.Id == id);

        protected override string getId(TDomain entity) => entity?.Data?.Id;

    }

}
