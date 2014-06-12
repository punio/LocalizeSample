using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalizeTest
{
	[ContentProperty("Text")]
	public class LocalizedStringExtension : IMarkupExtension
	{
		public string Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Text == null) return null;
			return Strings.ResourceManager.GetString(Text);
		}
	}
}
