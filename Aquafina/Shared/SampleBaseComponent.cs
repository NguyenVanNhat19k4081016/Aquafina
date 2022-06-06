using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
namespace Aquafina.Shared
{
    public class SampleBaseComponent : ComponentBase
    {
        [Inject]
        protected SampleService SampleService { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            //SampleService.Spinner?.Hide();
            //SampleService.Spinner?.ShowModalSpinner(false);
        }
    }
}
