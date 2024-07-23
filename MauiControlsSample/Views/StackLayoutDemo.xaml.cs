namespace MauiControlsSample.Views;

public partial class StackLayoutDemo : ContentPage
{
    public StackLayoutDemo()
    {
        InitializeComponent();
        this.SizeChanged += OnPageSizeChanged;
    }

    private void OnPageSizeChanged(object sender, EventArgs e)
    {
        if (Width > Height)
        {
            mainStack.Orientation = StackOrientation.Horizontal;
        }
        else
        {
            mainStack.Orientation = StackOrientation.Vertical;
        }
    }
}