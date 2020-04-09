using System.Threading.Tasks;
using HW4.Domain.Quantity;
using HW4.Facade.Quantity;
using HW4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace HW4.Soft.Areas.Quantity.Pages.UnitFactors
{
    public class DetailsModel : UnitFactorsPage
    {
        public DetailsModel(IUnitFactorsRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
