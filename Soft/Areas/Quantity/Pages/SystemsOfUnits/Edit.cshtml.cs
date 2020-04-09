using System.Threading.Tasks;
using HW4.Domain.Quantity;
using HW4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace HW4.Soft.Areas.Quantity.Pages.SystemsOfUnits
{
    public class EditModel : SystemsOfUnitsPage
    {
        public EditModel(ISystemsOfUnitsRepository r) : base(r)
        {
        }


        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await updateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

    }
}
