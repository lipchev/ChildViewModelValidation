using Catel.MVVM.Providers;

namespace ChildViewModelValidation;

public partial class ChildView
{
    public ChildView()
    {
        DefaultUnloadBehaviorValue = UnloadBehavior.CancelAndCloseViewModel;
        InitializeComponent();
    }
}