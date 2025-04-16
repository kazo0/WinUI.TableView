namespace WinUI.TableView.SampleApp;

public class Program
{
    private static App? _app;
    public static int Main(string[] args)
    {
        Microsoft.UI.Xaml.Application.Start(_ => _app = new App());

        return 0;
    }
    // public static async Task Main(string[] args)
    // {
    //         var host = new Uno.UI.Runtime.Skia.WebAssembly.Browser.WebAssemblyBrowserHost(() => _app = new App());
	// 		await host.Run();
    // }
}
