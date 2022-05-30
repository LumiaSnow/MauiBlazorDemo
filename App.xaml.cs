using MauiApp2.Repositories;

namespace MauiApp2;

public partial class App : Application
{
    private readonly LogRepository _logRepository;
    public App(LogRepository logRepository)
	{
        _logRepository = logRepository;

        InitializeComponent();

		MainPage = new MainPage(_logRepository);
        //PageAppearing += async (sender, e) => {
        //   await _logRepository.LogDebugAsync("App PageAppearing", e.Title);
        //};
        //PageDisappearing += async (sender, e) => {
        //    await _logRepository.LogDebugAsync("App PageDisappearing", e.Title);
        //};
        //ModalPopping += async (sender, e) => {
        //    await _logRepository.LogDebugAsync("App ModalPopping", e.Modal.Title);
        //};
        //ModalPopped += async (sender, e) => {
        //    await _logRepository.LogDebugAsync("App ModalPopped", e.Modal.Title);
        //};
        //ModalPushing += async (sender, e) => {
        //    await _logRepository.LogDebugAsync("App ModalPushing", e.Modal.Title);
        //};
        //ModalPushed += async (sender, e) => {
        //    await _logRepository.LogDebugAsync("App ModalPushed", e.Modal.Title);
        //};
        //RequestedThemeChanged += async (sender, e) => {
        //    await _logRepository.LogDebugAsync("App RequestedThemeChanged", e.RequestedTheme.ToString());
        //};

    }

    protected override void OnStart()
    {
        _logRepository.LogDebug("App OnStart", "Start");
        base.OnStart();
        _logRepository.LogDebug("App OnStart", "End");
    }
    protected override void OnSleep()
    {
        _logRepository.LogDebug("App OnSleep", "Start");
        base.OnSleep();
        _logRepository.LogDebug("App OnSleep", "End");
    }
    protected override void OnResume()
    {
        _logRepository.LogDebug("App OnResume", "Start");
        base.OnResume();
        _logRepository.LogDebug("App OnResume", "End");
    }
    //protected override void OnAppLinkRequestReceived(Uri uri)
    //{
    //    _logRepository.LogDebug("App OnAppLinkRequestReceived", $"Start {uri.ToString()}");
    //    base.OnAppLinkRequestReceived(uri);
    //    _logRepository.LogDebug("App OnAppLinkRequestReceived", $"End {uri.ToString()}");
    //}
    //protected override void CleanUp() {
    //    _logRepository.LogDebug("App CleanUp", "Start");
    //    base.CleanUp();
    //    _logRepository.LogDebug("App CleanUp", "End");
    //}

    //public override void OpenWindow(Window window)
    //{
    //    _logRepository.LogDebug("App OpenWindow", $"Start {window.Title}");
    //    base.OpenWindow(window);
    //    _logRepository.LogDebug("App OpenWindow", $"End {window.Title}");
    //}

    //public override void CloseWindow(Window window)
    //{
    //    _logRepository.LogDebug("App CloseWindow", $"Start {window.Title}");
    //    base.CloseWindow(window);
    //    _logRepository.LogDebug("App CloseWindow", $"End {window.Title}");
    //}

    protected override Window CreateWindow(IActivationState activationState)
    {
        _logRepository.LogDebug("App CreateWindow", $"Start {activationState.State}");
        var window = base.CreateWindow(activationState);
        window.Activated += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"Activated"); };
        window.Resumed += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"Resumed"); };
        window.Stopped += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"Stopped"); };
        window.Created += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"Created"); };
        window.Deactivated += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"Deactivated"); };
        window.Destroying += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"Destroying"); };
        //window.PopCanceled += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"PopCanceled"); };
        //window.ModalPushing += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"ModalPushing"); };
        //window.ModalPushed += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"ModalPushed"); };
        //window.ModalPopping += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"ModalPopping"); };
        //window.DisplayDensityChanged += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"DisplayDensityChanged"); };
        //window.Backgrounding += async (sender, e) => { await _logRepository.LogDebugAsync("Window", $"Backgrounding"); };
        _logRepository.LogDebug("App CreateWindow", $"End {window.Title}");
        return window;
    }
}
