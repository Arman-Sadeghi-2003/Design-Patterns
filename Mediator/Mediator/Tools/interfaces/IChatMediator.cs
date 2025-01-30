using Mediator.Models;

namespace Mediator.Tools.interfaces
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void AddUser(User user);
    }
}
