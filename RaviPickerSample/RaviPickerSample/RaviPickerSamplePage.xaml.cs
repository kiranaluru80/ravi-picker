using Xamarin.Forms;

namespace RaviPickerSample
{
	public partial class RaviPickerSamplePage : ContentPage
	{
		RaviPickerSamplePageViewModal vm;

		public RaviPickerSamplePage()
		{
			InitializeComponent();
            this.BindingContext = vm = new RaviPickerSamplePageViewModal();

		}
	}
}
