using System.Threading.Tasks;
using HW4.Domain.Quantity;
using HW4.Pages.Quantity;

namespace HW4.Soft.Areas.Quantity.Pages.MeasureTerms
{
    public class IndexModel : MeasureTermsPage
    {

        public IndexModel(IMeasureTermsRepository r, IMeasuresRepository m) : base(r, m)
        {
    }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
