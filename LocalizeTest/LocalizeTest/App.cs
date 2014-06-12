using Xamarin.Forms;

namespace LocalizeTest
{
	public class App
	{
		public static Page GetMainPage()
		{
			return new XamlPage();
			return new ContentPage
			{
				Content = new StackLayout
				{
					Children = {
						new Label
						{
//							Text = "Hello, Forms !",
							Text = Strings.Hello,
							VerticalOptions = LayoutOptions.CenterAndExpand,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
						},
						new Label
						{
							Text = System.Globalization.CultureInfo.CurrentCulture.ToString(),
							VerticalOptions = LayoutOptions.CenterAndExpand,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
						},
					},
				}
			};
		}
	}
}
