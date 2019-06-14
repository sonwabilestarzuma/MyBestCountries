using System.Threading.Tasks;

namespace MyBestCountries.Controllers
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string v, object message);
    }
}