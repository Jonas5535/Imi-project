using System;

namespace Imi.Project.Api.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime? AddedOn { get; set; } //Only used to add extra info to database
        public DateTime? ModifiedOn { get; set; } //Only used to order list on server side
    }
}
