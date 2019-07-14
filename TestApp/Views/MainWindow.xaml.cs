using Interfaces;
using ModuleA.Views;
using ModuleB.Views;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Windows;

namespace TestApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        IContainerExtension _container;
        IRegionManager _regionManager;

        public MainWindow(IContainerExtension container, IRegionManager regionManager)
        {
            InitializeComponent();
            _container = container;
            _regionManager = regionManager;
           
        }
        protected override void OnContentRendered(EventArgs e) {
            var view = _container.Resolve<IBaseModule>();
            IRegion region = _regionManager.Regions["ContentRegion"];
            region.Add(view);
        }
    }
}
