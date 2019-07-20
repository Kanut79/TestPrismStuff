using Interfaces;
using System.Windows.Controls;

namespace ModuleB.Views
{
    /// <summary>
    /// Interaction logic for ViewB
    /// </summary>
    public partial class ViewB : UserControl, ITestModuleB
    {
        public ViewB()
        {
            InitializeComponent();
        }
    }
}
