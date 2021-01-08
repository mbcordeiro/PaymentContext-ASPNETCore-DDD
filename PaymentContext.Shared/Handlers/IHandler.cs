using PaymentContext.Shared.Commands;

namespace PaymentContext.Shared.Handlers
{
    public interface IHandler<T> 
    {
        ICommandResult Handle(T command);
    }
}