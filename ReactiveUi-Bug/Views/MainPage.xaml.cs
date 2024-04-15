using ReactiveUi_Bug.ViewModels;

namespace ReactiveUi_Bug.Views;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        ViewModel = new MainPageViewModel();
    }



    public MainPageViewModel ViewModel
    {
        get
        {
            return ( MainPageViewModel )GetValue(ViewModelProperty);
        }
        set
        {
            SetValue(ViewModelProperty , value);
        }
    }

    // Using a DependencyProperty as the backing store for ViewModel.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty ViewModelProperty =
        DependencyProperty.Register("ViewModel" , typeof(MainPageViewModel) , typeof(MainPage) , new PropertyMetadata(new MainPageViewModel()));


}

