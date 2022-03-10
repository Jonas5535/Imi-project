using System;

namespace Imi.Project.Api.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
