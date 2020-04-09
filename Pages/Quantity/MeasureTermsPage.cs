using System.Collections.Generic;
using HW4.Data.Quantity;
using HW4.Domain.Quantity;
using HW4.Facade.Quantity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HW4.Pages.Quantity
{
    public class MeasureTermsPage : CommonPage<IMeasureTermsRepository, MeasureTerm, MeasureTermView, MeasureTermData>
    {
        protected internal MeasureTermsPage(IMeasureTermsRepository r, IMeasuresRepository m) : base(r)
        {
            PageTitle = "Measure Terms";
            Measures = createSelectList<Measure, MeasureData>(m);
        }

        public IEnumerable<SelectListItem> Measures { get; }

        public override string ItemId
        {
            get {
                if (Item is null) return string.Empty;
                return $"{Item.MasterId}.{Item.TermId}";
            }
        }

        protected internal override string getPageUrl() => "/Quantity/MeasureTerms";

        protected internal override MeasureTerm toObject(MeasureTermView view)
        {
            return MeasureTermViewFactory.Create(view);
        }

        protected internal override MeasureTermView toView(MeasureTerm obj)
        {
            return MeasureTermViewFactory.Create(obj);
        }

        public string GetMeasureName(string measureId)
        {
            foreach (var m in Measures)
                if (m.Value == measureId)
                    return m.Text;

            return "Unspecified";
        }

        protected internal override string getPageSubTitle()
        {
            return FixedValue is null
                ? base.getPageSubTitle()
                : $"For {GetMeasureName(FixedValue)}";
        }
    }
}
