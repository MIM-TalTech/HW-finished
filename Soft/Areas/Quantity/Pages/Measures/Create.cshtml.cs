using System.Threading.Tasks;
using HW4.Domain.Quantity;
using HW4.Facade.Quantity;
using HW4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace HW4.Soft.Areas.Quantity.Pages.Measures
{
    public class CreateModel : MeasuresPage
    {
        public CreateModel(IMeasuresRepository r, IMeasureTermsRepository t) : base(r, t)
        {
        }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await addObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
