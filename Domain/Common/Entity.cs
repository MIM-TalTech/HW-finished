﻿using HW4.Data.Common;

namespace HW4.Domain.Common
{
    public abstract class Entity<TData> where TData: PeriodData, new() {

        protected internal Entity(TData d = null) => Data = d;
        public TData Data { get; internal set; }
    }
}
