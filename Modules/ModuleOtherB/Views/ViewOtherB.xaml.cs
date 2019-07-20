using Interfaces;
using System.Windows.Controls;

namespace ModuleOtherB.Views
{
    /// <summary>
    /// Interaction logic for ViewOtherB
    /// </summary>
    public partial class ViewOtherB : UserControl, ITestModuleB
    {
        public ViewOtherB()
        {
            InitializeComponent();
        }
    }
}
