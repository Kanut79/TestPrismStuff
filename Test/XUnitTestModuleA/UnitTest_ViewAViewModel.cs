using ModuleA.ViewModels;
using Xunit;

namespace XUnitUITest_ModuleA
{
    public class UnitTest_ViewAViewModel
    {
        [Fact]
        public void Test_Message()
        {
            var viewModel = new ViewAViewModel();
            viewModel.Message = "Test";
            Assert.Equal("Test", viewModel.Message);
        }
    }
}
