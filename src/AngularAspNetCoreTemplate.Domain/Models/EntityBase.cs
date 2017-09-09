using AngularAspNetCoreTemplate.Domain.Abstract;

namespace AngularAspNetCoreTemplate.Domain.Models
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
    }
}