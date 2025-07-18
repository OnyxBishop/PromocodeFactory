﻿using System;

namespace PromoCodeFactory.Core.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public abstract bool IsDeleted { get; set; }
    }
}