using System.ComponentModel.DataAnnotations.Schema;
using Repository.Pattern.Infrastructure;

namespace Repository.Pattern.EF6
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}