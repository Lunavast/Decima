namespace Decima.Droid
{
	#region

	using Android.Content;
	using Decima.Core;
	using MvvmCross.Core.ViewModels;
	using MvvmCross.Droid.Platform;
	using MvvmCross.Platform.Platform;

	#endregion

	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext) : base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}

		protected override IMvxTrace CreateDebugTrace()
		{
			return new DebugTrace();
		}
	}
}