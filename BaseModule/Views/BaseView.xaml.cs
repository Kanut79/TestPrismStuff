using BaseModule.ViewModels;
using Interfaces;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace BaseModule.Views
{
    /// <summary>
    /// Interaction logic for BaseView
    /// </summary>
    public partial class BaseView : UserControl, IBaseModule
    {
        IContainerExtension _container;
        IRegionManager _regionManager;

        // Dependency Injection with ServiceLocator. Possible nullReferenceException if CommonServiceLocator.ServiceLocator.Current not set.
        public BaseView()
        {
            InitializeComponent();
            _container = CommonServiceLocator.ServiceLocator.Current.GetInstance<IContainerExtension>();
            _regionManager = CommonServiceLocator.ServiceLocator.Current.GetInstance<IRegionManager>();
        }

        // Dependency Injection with constructor properties. View can not be directly referenced in .xaml files
        public BaseView(IContainerExtension container, IRegionManager regionManager)
        {
            InitializeComponent();
            _container = container;
            _regionManager = regionManager;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = this.DataContext as BaseViewViewModel;
            viewModel.Message = "Modules loaded";
            var viewA = _container.Resolve<ITestModuleA>();
            IRegion testModuleARegion = _regionManager.Regions["ITestModuleARegion"];
            testModuleARegion.Add(viewA);
            var viewB = _container.Resolve<ITestModuleB>();
            IRegion testModuleBRegion = _regionManager.Regions["ITestModuleBRegion"];
            testModuleBRegion.Add(viewB);
        }
    }
}
