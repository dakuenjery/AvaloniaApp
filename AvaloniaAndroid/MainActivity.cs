using Android.App;
using Android.OS;
using Android.Runtime;
using Avalonia.Android;
using Avalonia;
using Todo;

namespace AvaloniaAndroid {
	[Activity(Label = "@string/app_name", MainLauncher = true)]
	public class MainActivity : AvaloniaActivity {
		protected override void OnCreate(Bundle savedInstanceState) {
			if (Avalonia.Application.Current == null) {
				AppBuilder.Configure<App>()
					.UseAndroid()
					.SetupWithoutStarting();
				Content = new Todo.Views.TodoListView();
			}

			base.OnCreate(savedInstanceState);
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults) {
			Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

			base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}
	}
}