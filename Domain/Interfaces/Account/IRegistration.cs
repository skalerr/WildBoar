using Domain.Entities;

namespace Domain.Interfaces.Account;

public interface IRegistration
{
    public Client Add(Client client);
}