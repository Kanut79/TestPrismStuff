using Interfaces;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
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
            var baseView = _container.Resolve<IBaseModule>();
            IRegion region = null;
            try
            {
                region = _regionManager.Regions["ContentRegion"];
            }
            catch (KeyNotFoundException)
            {
            }
                
            if (region != null && baseView != null)
            { 
                region.Add(baseView);
            }        }
    }
}
