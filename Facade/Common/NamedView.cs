using System.ComponentModel.DataAnnotations;
using HW4.Facade.Quantity;

namespace HW4.Facade.Common
{
    public abstract class NamedView : UniqueEntityView
    {
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
