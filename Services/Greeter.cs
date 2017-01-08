using Microsoft.Extensions.Configuration;

namespace NewsApp.Services
{
    public interface IGreeter
    {
        string GetGreeting();
    }

    public class Greeter : IGreeter
    {
        private readonly string _greeting;

        public Greeter(IConfiguration config)
        {
            _greeting = config["greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }
    }
}