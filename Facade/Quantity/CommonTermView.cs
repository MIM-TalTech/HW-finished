using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HW4.Facade.Common;

namespace HW4.Facade.Quantity
{
    public abstract class CommonTermView : PeriodView
    {
        [Required]
        [DisplayName("Term")]
        public string TermId { get; set; }
        public int Power { get; set; }
    }
}
