using Prism.Ioc;
using TestApp.Views;
using System.Windows;
using ModuleA.Views;
using Interfaces;
using ModuleB.Views;
using ModuleOtherB;
using ModuleOtherB.Views;
using BaseModule.Views;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IBaseModule, BaseView>();
            containerRegistry.Register<ITestModuleA, ViewA>();
            containerRegistry.Register<ITestModuleB, ViewB>();
            //containerRegistry.Register<ITestModuleB, ViewOtherB>();
        }
    }
}
