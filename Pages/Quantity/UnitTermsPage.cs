using System.Collections.Generic;
using HW4.Data.Quantity;
using HW4.Domain.Quantity;
using HW4.Facade.Quantity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HW4.Pages.Quantity
{
    public class UnitTermsPage : CommonPage<IUnitTermsRepository, UnitTerm, UnitTermView, UnitTermData>
    {
        protected internal UnitTermsPage(IUnitTermsRepository r, IUnitsRepository u) : base(r)
        {
            PageTitle = "Unit Terms";
            Units = createSelectList<Unit, UnitData>(u);
        }

        public IEnumerable<SelectListItem> Units { get; }

        public override string ItemId
        {
            get
            {
                if (Item is null) return string.Empty;
                return $"{Item.MasterId}.{Item.TermId}";
            }
        }

        protected internal override string getPageUrl() => "/Quantity/UnitTerms";

        protected internal override UnitTerm toObject(UnitTermView view)
        {
            return UnitTermViewFactory.Create(view);
        }

        protected internal override UnitTermView toView(UnitTerm obj)
        {
            return UnitTermViewFactory.Create(obj);
        }
    }
}
