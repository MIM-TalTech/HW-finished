using System.Collections.Generic;
using System.Threading.Tasks;
using HW4.Data.Quantity;
using HW4.Domain.Quantity;
using HW4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HW4.Soft.Areas.Quantity.Pages.UnitFactors
{
    public class CreateModel : UnitFactorsPage
    {
        public CreateModel(IUnitFactorsRepository r, IUnitsRepository u, ISystemsOfUnitsRepository s) : base(r)
        {
            Units = createSelectList<Unit, UnitData>(u);
            SystemsOfUnits = createSelectList<SystemOfUnits, SystemOfUnitsData>(s);
        }

        public IEnumerable<SelectListItem> Units { get; }
        public IEnumerable<SelectListItem> SystemsOfUnits { get; }

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
