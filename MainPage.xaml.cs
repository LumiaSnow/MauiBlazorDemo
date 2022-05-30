using MauiApp2.Repositories;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
    private readonly LogRepository _logRepository;
    public MainPage(LogRepository logRepository)
    {
        _logRepository = logRepository;
		InitializeComponent();
        this.Appearing += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "Appearing");  };
        //this.BindingContextChanged += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "BindingContextChanged"); };
        //this.Disappearing += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "Disappearing"); };
        //this.Focused += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "Focused"); };
        this.Loaded += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "Loaded"); };
        //this.Unloaded += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "Unloaded"); };
        this.SizeChanged += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "SizeChanged"); };
        this.LayoutChanged += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "LayoutChanged"); };
        //this.ChildAdded += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "ChildAdded"); };
        //this.ChildRemoved += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "ChildRemoved"); };
        //this.ChildrenReordered += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "ChildrenReordered"); };
        //this.DescendantAdded += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "DescendantAdded"); };
        //this.DescendantRemoved += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "DescendantRemoved"); };
        //this.HandlerChanged += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "HandlerChanged"); };
        //this.HandlerChanging += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "HandlerChanging"); };
        //this.MeasureInvalidated += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "MeasureInvalidated"); };
        //this.NavigatedFrom += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "NavigatedFrom"); };
        //this.NavigatedTo += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "NavigatedTo"); };
        //this.NavigatingFrom += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "NavigatingFrom"); };
        //this.ParentChanged += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "ParentChanged"); };
        //this.ParentChanging += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "ParentChanging"); };
        //this.PropertyChanged += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "PropertyChanged"); };
        //this.PropertyChanging += async (sender, e) => { await _logRepository.LogDebugAsync("ContentPage", "PropertyChanging"); };
    }
}
