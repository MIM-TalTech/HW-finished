using HW4.Data.Quantity;
using HW4.Domain.Quantity;
using HW4.Facade.Quantity;

namespace HW4.Pages.Quantity
{
    public class SystemsOfUnitsPage : CommonPage<ISystemsOfUnitsRepository, SystemOfUnits, SystemOfUnitsView, SystemOfUnitsData>
    {
        protected internal SystemsOfUnitsPage(ISystemsOfUnitsRepository r) : base(r)
        {
            PageTitle = "Systems of Units";
        }

        public override string ItemId => Item.Id;

        protected internal override string getPageUrl() => "/Quantity/SystemsOfUnits";

        protected internal override SystemOfUnits toObject(SystemOfUnitsView view)
        {
            return SystemOfUnitsViewFactory.Create(view);
        }

        protected internal override SystemOfUnitsView toView(SystemOfUnits obj)
        {
            return SystemOfUnitsViewFactory.Create(obj);
        }
    }
}
