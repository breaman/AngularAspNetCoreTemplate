using AngularAspNetCoreTemplate.Domain.Abstract;

namespace AngularAspNetCoreTemplate.Domain.Models
{
    public class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}