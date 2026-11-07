using Weather_Report.Models;
using Weather_Report.ViewModels;

namespace Weather_Report.Views;

public partial class ClimaView : ContentPage
{
	public ClimaView()
	{
		InitializeComponent();
		BindingContext = new ClimaViewModel();

	}
}