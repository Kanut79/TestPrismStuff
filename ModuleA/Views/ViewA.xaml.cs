using Interfaces;
using System.Windows.Controls;

namespace ModuleA.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ViewA : UserControl, ITestModuleA
    {
        public ViewA()
        {
            InitializeComponent();
        }
    }
}
