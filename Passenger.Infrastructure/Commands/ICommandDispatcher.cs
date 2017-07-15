using System.Threading.Tasks;
using Passenger.Infrastructure.Commands.Users;

namespace Passenger.Infrastructure.Commands
{
    //Dispatch command to right handler
    public interface ICommandDispatcher
    {
         Task DispatchAsync<T>(T command) where T : ICommand;
    }
}