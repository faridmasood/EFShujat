using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime Updated { get; set; }
    }
}