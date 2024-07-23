using Microsoft.Maui.Layouts;

namespace MauiControlsSample.Layouts
{
    public class ZStackLayout : StackBase
    {
        protected override ILayoutManager CreateLayoutManager() => new ZStackLayoutManager(this);
    }
}
