using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HW4.Facade.Common;

namespace HW4.Facade.Quantity
{
    public sealed class MeasureTermView : CommonTermView
    {
        [Required]
        [DisplayName("Measure")]
        public string MasterId { get; set; }

        public string GetId()
        {
            return $"{MasterId}.{TermId}";
        }
    }
}
