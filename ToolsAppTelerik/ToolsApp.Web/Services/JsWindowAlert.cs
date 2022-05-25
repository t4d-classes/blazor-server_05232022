using System.Threading.Tasks;
using Microsoft.JSInterop;

using ToolsApp.Core.Interfaces.Web;

namespace ToolsApp.Web.Services
{
  public class JsWindowAlert: IAlert
  {
    private readonly IJSRuntime _js;

    public JsWindowAlert(IJSRuntime js) {
      _js = js;
    }

    public async Task Notify(string message)
    {
      await _js.InvokeVoidAsync("alert", message);
    }
  }

}