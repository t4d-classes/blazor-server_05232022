using System.Threading.Tasks;

namespace ToolsApp.Core.Interfaces.Web
{
  public interface IAlert
  {
    Task Notify(string message);
  }
}