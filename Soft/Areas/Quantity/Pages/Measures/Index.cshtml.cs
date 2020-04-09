using System.Threading.Tasks;
using HW4.Domain.Quantity;
using HW4.Pages.Quantity;

namespace HW4.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {
        public IndexModel(IMeasuresRepository r, IMeasureTermsRepository t) : base(r, t) { }

        public async Task OnGetAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}
