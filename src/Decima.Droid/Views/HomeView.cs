namespace Decima.Droid.Views
{
	#region

	using Android.App;
	using Android.Content.PM;
	using Android.OS;
	using Decima.Core.ViewModels;
	using MvvmCross.Droid.Support.V7.AppCompat;

	#endregion

	[Activity(
		Theme = "@style/AppTheme.Login",
		ScreenOrientation = ScreenOrientation.Portrait
		)]
	public class HomeView : MvxAppCompatActivity<HomeViewModel>
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.HomeView);
		}
	}
}