#if WINDOWS_UWP
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
#else
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Hosting;
#endif

namespace ExpressionAnimationRegression;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        InitializeAnimation();
    }

    private void InitializeAnimation()
    {
        var properties = ElementCompositionPreview.GetPointerPositionPropertySet(ContentGrid);
        var animation = properties.Compositor.CreateExpressionAnimation($"pointer.Position");

        animation.SetReferenceParameter("pointer", properties);
        animation.Target = "Translation";

        AnimatedBorder.StartAnimation(animation);
    }
}
