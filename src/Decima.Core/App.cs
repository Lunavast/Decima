namespace Decima.Core
{
	#region

	using MvvmCross.Core.ViewModels;
	using MvvmCross.Platform.IoC;

	#endregion

	public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			RegisterAppStart(new AppStart());
		}
	}
}