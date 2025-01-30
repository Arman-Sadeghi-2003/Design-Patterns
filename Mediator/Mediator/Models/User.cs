using Mediator.Tools.interfaces;

namespace Mediator.Models
{
    public class User
    {
        private string _name;
        private IChatMediator _mediator;

        public User(string name, IChatMediator mediator)
        {
            _name = name;
            _mediator = mediator;
            _mediator.AddUser(this);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{_name} sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message, User sender)
        {
            Console.WriteLine($"{_name} received from {sender.GetName()}: {message}");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
