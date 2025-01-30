using Mediator.Tools.interfaces;

namespace Mediator.Models
{
    public class ChatMediator : IChatMediator
    {
        List<User> Users = new();

        public void AddUser(User user)
        {
            Users.Add(user);

        }

        public void SendMessage(string message, User user)
        {
            throw new NotImplementedException();
        }
    }
}
