namespace BankTest.Views;

public partial class MapPage : ContentPage
{
	public MapPage(MapViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

        var mapControl = new Mapsui.UI.Maui.MapControl();

        mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
        
		Content = mapControl;

#if WINDOWS
		// Note that the map control is not supported on Windows.
		// For more details, see https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/map?view=net-maui-7.0
		// For a possible workaround, see https://github.com/CommunityToolkit/Maui/issues/605
		Content = new Label() { Text = "Windows does not have a map control. 😢" };
#endif



    }
}
