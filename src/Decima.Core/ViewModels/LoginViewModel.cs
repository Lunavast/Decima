namespace Decima.Core.ViewModels
{
	#region

	using MvvmCross.Core.ViewModels;

	#endregion

	public class LoginViewModel : MvxViewModel
	{
		public string LoginTitle { get; private set; } = "Welcome to Taze.App";
		public virtual IMvxCommand LoginCommand => new MvxCommand(() => ShowViewModel<HomeViewModel>());
	}
}