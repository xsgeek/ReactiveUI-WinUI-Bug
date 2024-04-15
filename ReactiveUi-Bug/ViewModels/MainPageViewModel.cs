
using System.Reactive.Disposables;

using ReactiveUI;

namespace ReactiveUi_Bug.ViewModels;

// uncomment this section to see it work

#region ' Works with this section '

//public class MainPageViewModel
//{
//    public MainPageViewModel()
//    {
//    }
//}

#endregion // Works with this section



#region ' Doesn't work if you use this section '

public class MainPageViewModel
: IActivatableViewModel
{

    public ViewModelActivator Activator
    {
        get;
    }

    public MainPageViewModel()
    {
        Activator = new ViewModelActivator();

        ( this ).WhenActivated(disposables =>
        {
            // Use WhenActivated to execute logic
            // when the view model gets activated.
            HandleActivation(disposables);
        });
    }

    private void HandleActivation(CompositeDisposable disposables)
    {

        System.Diagnostics.Debug.WriteLine("good luck ever actually getting here");


    }

}

#endregion // Doesn't work if you use this section


